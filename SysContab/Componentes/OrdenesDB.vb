Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Namespace VB.SysContab

    Public Class OrdenesDetails
        Public Numero As String
        Public Factura As String
        Public Fecha As String
        Public CodigoCliente As String
        Public Ruc As String

        Public Monto As String
        Public SubTotal As String
        Public DescuentoP As String
        Public DescuentoC As String
        Public IvaP As String
        Public IvaC As String
        Public RecargoP As String
        Public RecargoC As String
        Public OtrosP As String
        Public OtrosC As String
        Public Total As String

        Public Saldo As String
        Public FormaPago As String
        Public Vendedor As String
        Public ComisionP As String
        Public ComisionC As String
        Public FechaCancelar As String
        Public FechaVencimiento As String
        Public Tipo As String

    End Class

    Public Class OrdenesDB

        Public Function OrdenesReporte(ByVal Estado As String, ByVal OrdenID As String, ByVal Mes As String, _
                    ByVal Fecha1 As String, ByVal Fecha2 As String, ByVal FormaPago As Integer, ByVal CodArticulo As String, _
                    ByVal Articulo As String, ByVal Cliente As Integer, ByVal FacRango1 As Integer, ByVal FacRango2 As Integer, _
                    ByVal ArtMin As String, ByVal ArtMax As String, ByVal TipoFac2 As String, ByVal TipoArt As String, _
                    ByVal Orden As Integer, ByVal Origen As Integer) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_OrdenesComprasCliente", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.Char)
            Dim pOrdenID As New SqlParameter("@OrdenID", SqlDbType.NVarChar)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.NVarChar)
            Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim pTipoArt As New SqlParameter("@TipoArt", SqlDbType.Char)
            Dim pTipoFac2 As New SqlParameter("@TipoFac2", SqlDbType.Char)
            Dim pCodArticulo As New SqlParameter("@ItemID", SqlDbType.NVarChar)
            Dim pFacRango1 As New SqlParameter("@FacRango1", SqlDbType.Float)
            Dim pFacRango2 As New SqlParameter("@FacRango2", SqlDbType.Float)
            Dim pArtMin As New SqlParameter("@ArtMin", SqlDbType.Float)
            Dim pArtMAx As New SqlParameter("@ArtMax", SqlDbType.Float)
            Dim pFormaPago As New SqlParameter("@FormaPago", SqlDbType.Int)
            Dim pArticulo As New SqlParameter("@Articulo", SqlDbType.NVarChar)
            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.Int)
            Dim pOrden As New SqlParameter("@Orden", SqlDbType.Int)
            Dim pOrigen As New SqlParameter("@Origen", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual
            pEstado.Value = Estado
            pOrdenID.Value = OrdenID
            pMes.Value = Mes
            pFecha1.Value = Fecha1
            pFecha2.Value = Fecha2
            pFormaPago.Value = FormaPago
            pCodArticulo.Value = CodArticulo
            pArticulo.Value = Articulo
            pCliente.Value = Cliente
            pFacRango1.Value = FacRango1
            pFacRango2.Value = FacRango2
            pArtMin.Value = ArtMin
            pArtMAx.Value = ArtMax
            pTipoArt.Value = TipoArt
            pTipoFac2.Value = TipoFac2
            pOrden.Value = Orden
            pOrigen.Value = Origen

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pOrdenID)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pFecha1)
            DBCommand.SelectCommand.Parameters.Add(pFecha2)
            DBCommand.SelectCommand.Parameters.Add(pFormaPago)
            DBCommand.SelectCommand.Parameters.Add(pCodArticulo)
            DBCommand.SelectCommand.Parameters.Add(pArticulo)
            DBCommand.SelectCommand.Parameters.Add(pCliente)
            DBCommand.SelectCommand.Parameters.Add(pFacRango1)
            DBCommand.SelectCommand.Parameters.Add(pFacRango2)
            DBCommand.SelectCommand.Parameters.Add(pArtMin)
            DBCommand.SelectCommand.Parameters.Add(pArtMAx)
            DBCommand.SelectCommand.Parameters.Add(pTipoArt)
            DBCommand.SelectCommand.Parameters.Add(pTipoFac2)
            DBCommand.SelectCommand.Parameters.Add(pOrden)
            DBCommand.SelectCommand.Parameters.Add(pOrigen)
            'Try
            DBCommand.Fill(dsFicha, "Ordenes")
            'Catch e As Exception
            '    MsgBox(e.Message)
            'End Try
            DBConn.Close()
            Return dsFicha

        End Function


        Public Function ImprimirOrden(ByVal Orden As Long) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())
            DBCommand = New SqlDataAdapter("_OrdenesComprasClientesRep", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pOrden As New SqlParameter("@Factura", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            pOrden.Value = Orden
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pOrden)
            DBCommand.Fill(dsFicha, "Ordenes")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function UpdateOrden(ByVal Factura As String, ByVal Fecha As String, ByVal Cliente As String, _
                                    ByVal Ruc As String, ByVal Monto As String, ByVal SubTotal As String, _
                                    ByVal Descuento As String, ByVal Iva As String, ByVal Recargo As String, _
                                    ByVal Otros As String, ByVal Total As String, ByVal Saldo As String, _
                                    ByVal Vendedor As String, ByVal Fecha_Pago As String, _
                                    ByVal Fecha_Vencimiento As String, ByVal Tipo As String, _
                                    ByVal Tipo_Factura As String, ByVal PvCodigo As String, ByVal NombreCliente As String, _
                                    ByVal Remision As Integer, ByVal Traslado As Integer, _
                                    ByVal Bodega As String, Optional ByVal DirEntrega As String = "", Optional ByVal Centro As Integer = 0)


            Dim cmd As SqlCommand = New SqlCommand("_OrdenesUpdate", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime, 8)
            Dim _Cliente As SqlParameter = New SqlParameter("@Cliente", SqlDbType.Int, 4)
            Dim _Ruc As SqlParameter = New SqlParameter("@Ruc", SqlDbType.NVarChar, 50)
            Dim _Monto As SqlParameter = New SqlParameter("@Monto", SqlDbType.Float, 8)
            Dim _SubTotal As SqlParameter = New SqlParameter("@SubTotal", SqlDbType.Float, 8)
            Dim _Descuento As SqlParameter = New SqlParameter("@Descuento", SqlDbType.Float, 8)
            Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Recargo As SqlParameter = New SqlParameter("@Recargo", SqlDbType.Float, 8)
            Dim _Otros As SqlParameter = New SqlParameter("@Otros", SqlDbType.Float, 8)
            Dim _Total As SqlParameter = New SqlParameter("@Total", SqlDbType.Float, 8)
            Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Float, 8)
            Dim _Vendedor As SqlParameter = New SqlParameter("@Vendedor", SqlDbType.Int, 4)
            Dim _FechaPago As SqlParameter = New SqlParameter("@Fecha_Pago", SqlDbType.DateTime, 8)
            Dim _FechaVencimiento As SqlParameter = New SqlParameter("@Fecha_Vencimiento", SqlDbType.DateTime, 8)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int, 4)
            Dim _Tipo_Factura As SqlParameter = New SqlParameter("@Tipo_Factura", SqlDbType.Int, 4)
            Dim _PvCodigo As SqlParameter = New SqlParameter("@PvCodigo", SqlDbType.Int, 4)
            Dim _NombreCliente As SqlParameter = New SqlParameter("@NombreCliente", SqlDbType.NVarChar, 100)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Centro As SqlParameter = New SqlParameter("@Centro", SqlDbType.Int, 4)
            Dim _Bodega As SqlParameter = New SqlParameter("@Bodega", SqlDbType.NVarChar, 10)
            Dim _Entrega As SqlParameter = New SqlParameter("@DirEntrega", SqlDbType.NVarChar)
            Dim _Remision As SqlParameter = New SqlParameter("@Remision", SqlDbType.Bit)
            Dim _Traslado As SqlParameter = New SqlParameter("@Traslado", SqlDbType.Bit)

            _Factura.Value = Factura
            _Fecha.Value = Fecha
            _Cliente.Value = Cliente
            _Ruc.Value = Ruc
            _Monto.Value = Monto
            _SubTotal.Value = SubTotal
            _Descuento.Value = Descuento
            _Iva.Value = Iva
            _Recargo.Value = Recargo
            _Otros.Value = Otros
            _Total.Value = Total
            _Saldo.Value = Saldo
            _Vendedor.Value = Vendedor
            _FechaPago.Value = Fecha_Pago
            _FechaVencimiento.Value = Fecha_Vencimiento
            _Tipo.Value = Tipo
            _Tipo_Factura.Value = Tipo_Factura
            _PvCodigo.Value = PvCodigo
            _NombreCliente.Value = NombreCliente
            _Empresa.Value = EmpresaActual
            _Centro.Value = Centro
            _Bodega.Value = Bodega
            _Entrega.Value = DirEntrega
            _Remision.Value = Remision
            _Traslado.Value = Traslado

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Cliente)
            cmd.Parameters.Add(_Ruc)
            cmd.Parameters.Add(_Monto)
            cmd.Parameters.Add(_SubTotal)
            cmd.Parameters.Add(_Descuento)
            cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Recargo)
            cmd.Parameters.Add(_Otros)
            cmd.Parameters.Add(_Total)
            cmd.Parameters.Add(_Saldo)
            cmd.Parameters.Add(_Vendedor)
            cmd.Parameters.Add(_FechaPago)
            cmd.Parameters.Add(_FechaVencimiento)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Tipo_Factura)
            cmd.Parameters.Add(_PvCodigo)
            cmd.Parameters.Add(_NombreCliente)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Centro)
            cmd.Parameters.Add(_Bodega)
            cmd.Parameters.Add(_Entrega)
            cmd.Parameters.Add(_Remision)
            cmd.Parameters.Add(_Traslado)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
        End Function

        Public Function DeleteOrdenDetalle(ByVal Factura As String)
            Dim conexion As New VB.SysContab.Rutinas

            Dim cmd As SqlCommand = New SqlCommand("_OrdenesLineasDelete", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)


            _Factura.Value = Factura
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            'DBConn.Open()
            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
            'DBConn.Close()

        End Function

        Public Function Numero() As Integer
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_OrdenesNumero", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            cmd.Parameters.Add(pEmpresa)


            Dim parameterFactura As SqlParameter = New SqlParameter("@Factura", SqlDbType.Int, 4)
            parameterFactura.Direction = ParameterDirection.Output
            cmd.Parameters.Add(parameterFactura)


            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

            ' Return the Total
            If parameterFactura.Value.ToString() <> "" And (Not parameterFactura.Value Is DBNull.Value) Then
                Return CType(parameterFactura.Value, Integer)
            Else
                Return 1
            End If

        End Function

        Public Function OrdenDetalle(ByVal Factura As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_OrdenesDetalle", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Ordenes")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function OrdenDelete(ByVal Factura As String) As Boolean
            ' Create Instance of Connection and Command Object

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())


            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_OrdenesDelete", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)


            _Factura.Value = Factura
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Empresa)


            Try
                '''' Open the connection and execute the Command
                ''''
                DBConn.Open()
                cmd.ExecuteNonQuery()
                DBConn.Close()

                Return True
            Catch ex As Exception
                MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
                Return False
            End Try
        End Function

        Public Function AddLineas(ByVal Factura As String, ByVal Item As String, ByVal Cantidad As String, _
                                  ByVal Precio As String, ByVal Descuento As String, ByVal Total As String, _
                                  ByVal Comision As String, ByVal Tipo As String, ByVal Nuevo As Boolean, ByVal Iva As String)


            Dim cmd As SqlCommand = New SqlCommand("_OrdenesAddLineas", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar, 50)
            Dim _Cantidad As SqlParameter = New SqlParameter("@Cantidad", SqlDbType.Float, 8)
            Dim _Precio As SqlParameter = New SqlParameter("@Precio", SqlDbType.Float, 8)
            Dim _Descuento As SqlParameter = New SqlParameter("@Descuento", SqlDbType.Float, 8)
            Dim _Total As SqlParameter = New SqlParameter("@Total", SqlDbType.Float, 8)
            Dim _Comision As SqlParameter = New SqlParameter("@Comision", SqlDbType.Float, 8)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar, 2)
            Dim _Nuevo As SqlParameter = New SqlParameter("@Nuevo", SqlDbType.Bit)
            Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Factura.Value = Factura
            _Item.Value = Item
            _Cantidad.Value = Cantidad
            _Precio.Value = Precio
            _Descuento.Value = Descuento
            _Total.Value = Total
            _Comision.Value = Comision
            _Tipo.Value = Tipo
            _Nuevo.Value = Nuevo
            _Iva.Value = Iva
            _Empresa.Value = EmpresaActual


            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Cantidad)
            cmd.Parameters.Add(_Precio)
            cmd.Parameters.Add(_Descuento)
            cmd.Parameters.Add(_Total)
            cmd.Parameters.Add(_Comision)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Nuevo)
            cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function ListOrdenes(ByVal Filtro As String, ByVal Estado As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_OrdenesList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFiltro As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFiltro.Value = Filtro
            pEstado.Value = Estado
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFiltro)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Ordenes")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function AddOrden(ByVal Factura As String, ByVal Fecha As String, ByVal Cliente As String, _
                                        ByVal Ruc As String, ByVal Monto As Double, ByVal SubTotal As Double, _
                                        ByVal Descuento As Double, ByVal Iva As Double, ByVal Recargo As Double, _
                                        ByVal Otros As Double, ByVal Total As Double, ByVal Saldo As Double, _
                                        ByVal Vendedor As String, ByVal Fecha_Pago As String, _
                                        ByVal Fecha_Vencimiento As String, ByVal Tipo As String, _
                                        ByVal Tipo_Factura As String, ByVal PvCodigo As String, ByVal NombreCliente As String, _
                                        ByVal Remision As Integer, ByVal Traslado As Integer, _
                                        ByVal Bodega As String, Optional ByVal DirEntrega As String = "", Optional ByVal Centro As Integer = 0)


            Dim cmd As SqlCommand = New SqlCommand("_OrdenesAdd", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime, 8)
            Dim _Cliente As SqlParameter = New SqlParameter("@Cliente", SqlDbType.Int, 4)
            Dim _Ruc As SqlParameter = New SqlParameter("@Ruc", SqlDbType.NVarChar, 50)
            Dim _Monto As SqlParameter = New SqlParameter("@Monto", SqlDbType.Float, 8)
            Dim _SubTotal As SqlParameter = New SqlParameter("@SubTotal", SqlDbType.Float, 8)
            Dim _Descuento As SqlParameter = New SqlParameter("@Descuento", SqlDbType.Float, 8)
            Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Recargo As SqlParameter = New SqlParameter("@Recargo", SqlDbType.Float, 8)
            Dim _Otros As SqlParameter = New SqlParameter("@Otros", SqlDbType.Float, 8)
            Dim _Total As SqlParameter = New SqlParameter("@Total", SqlDbType.Float, 8)
            Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Float, 8)
            Dim _Vendedor As SqlParameter = New SqlParameter("@Vendedor", SqlDbType.Int, 4)
            Dim _FechaPago As SqlParameter = New SqlParameter("@Fecha_Pago", SqlDbType.DateTime, 8)
            Dim _FechaVencimiento As SqlParameter = New SqlParameter("@Fecha_Vencimiento", SqlDbType.DateTime, 8)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int, 4)
            Dim _Tipo_Factura As SqlParameter = New SqlParameter("@Tipo_Factura", SqlDbType.Int, 4)
            Dim _PvCodigo As SqlParameter = New SqlParameter("@PvCodigo", SqlDbType.Int, 4)
            Dim _NombreCliente As SqlParameter = New SqlParameter("@NombreCliente", SqlDbType.NVarChar, 100)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Centro As SqlParameter = New SqlParameter("@Centro", SqlDbType.Int, 4)
            Dim _Bodega As SqlParameter = New SqlParameter("@Bodega", SqlDbType.NVarChar, 10)
            Dim _Entrega As SqlParameter = New SqlParameter("@DirEntrega", SqlDbType.NVarChar)
            Dim _Remision As SqlParameter = New SqlParameter("@Remision", SqlDbType.Bit)
            Dim _Traslado As SqlParameter = New SqlParameter("@Traslado", SqlDbType.Bit)

            _Factura.Value = Factura
            _Fecha.Value = Fecha
            _Cliente.Value = Cliente
            _Ruc.Value = Ruc
            _Monto.Value = Monto
            _SubTotal.Value = SubTotal
            _Descuento.Value = Descuento
            _Iva.Value = Iva
            _Recargo.Value = Recargo
            _Otros.Value = Otros
            _Total.Value = Total
            _Saldo.Value = Saldo
            _Vendedor.Value = IIf(IsNumeric(Vendedor), Vendedor, 0)
            _FechaPago.Value = Fecha_Pago
            _FechaVencimiento.Value = Fecha_Vencimiento
            _Tipo.Value = Tipo
            _Tipo_Factura.Value = Tipo_Factura
            _PvCodigo.Value = PvCodigo
            _NombreCliente.Value = NombreCliente
            _Empresa.Value = EmpresaActual
            _Centro.Value = Centro
            _Bodega.Value = Bodega
            _Entrega.Value = DirEntrega
            _Remision.Value = Remision
            _Traslado.Value = Traslado

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Cliente)
            cmd.Parameters.Add(_Ruc)
            cmd.Parameters.Add(_Monto)
            cmd.Parameters.Add(_SubTotal)
            cmd.Parameters.Add(_Descuento)
            cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Recargo)
            cmd.Parameters.Add(_Otros)
            cmd.Parameters.Add(_Total)
            cmd.Parameters.Add(_Saldo)
            cmd.Parameters.Add(_Vendedor)
            cmd.Parameters.Add(_FechaPago)
            cmd.Parameters.Add(_FechaVencimiento)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Tipo_Factura)
            cmd.Parameters.Add(_PvCodigo)
            cmd.Parameters.Add(_NombreCliente)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Centro)
            cmd.Parameters.Add(_Bodega)
            cmd.Parameters.Add(_Entrega)
            cmd.Parameters.Add(_Remision)
            cmd.Parameters.Add(_Traslado)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
        End Function

        Public Function UpdateEstado(ByVal Factura As String)
            Dim cmd As SqlCommand = New SqlCommand("_OrdenesUpdateEstado", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)


            _Factura.Value = Factura
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

    End Class

End Namespace
