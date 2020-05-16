Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class BodegasDetails
        Public Codigo As String
        Public Ubicacion As String
        Public Encargado As String
        Public Cuenta_Inventario As String
        Public CapacidadM3 As Double
        Public Exigir_Facturacion As Boolean
        Public Fact_Sin_Existencia As Boolean
        Public Advertencia As Boolean
        Public Sucursal As String
        Public Gte_Ventas As String
        Public Gte_Mercadeo As String
        Public Gte_Sucursal As String
        Public Tecnico As String
    End Class

    Public Class BodegasDB

        Public Shared Function GetList_TransaccionBodega(ByVal Bodega As String, ByVal Tipo As String, _
            ByVal Documento As String, ByVal Proveedor As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_getTransacccionBodega", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Bodega", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Documento", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Proveedor", SqlDbType.Int)

            pIdent.Value = Bodega
            pIdent2.Value = EmpresaActual
            pIdent3.Value = Tipo
            pIdent4.Value = Documento
            pIdent5.Value = Proveedor
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)

            Try
                DBCommand.Fill(dsFicha, "Encabezado")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Contab")
                Return Nothing
            End Try
            Return dsFicha
        End Function

        Public Shared Function GetDetalledeBodegaxProducto(ByVal Articulo As String, ByVal TArticulo As String, _
           ByVal TDocumento As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetDetalledeBodegaxProducto", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Articulo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@TArticulo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@TDocumento", SqlDbType.NVarChar)

            pIdent.Value = Articulo
            pIdent2.Value = EmpresaActual
            pIdent3.Value = TArticulo
            pIdent4.Value = TDocumento

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)


            Try
                DBCommand.Fill(dsFicha, "Ubicaciones")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Contab")
                Return Nothing
            End Try
            Return dsFicha
        End Function
        Public Shared Function GetList_TransaccionBodegaDetalle(ByVal Bodega As String, ByVal Tipo As String, _
            ByVal Documento As String, ByVal Proveedor As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_getTransacccionBodega_DETALLE", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Bodega", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Documento", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Proveedor", SqlDbType.Int)

            pIdent.Value = Bodega
            pIdent2.Value = EmpresaActual
            pIdent3.Value = Tipo
            pIdent4.Value = Documento
            pIdent5.Value = Proveedor
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)

            Try
                DBCommand.Fill(dsFicha, "Detalle")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Contab")
                Return Nothing
            End Try
            Return dsFicha
        End Function

        Public Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListBodegasReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = Empresa
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "EMPLEADOS")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function GetDetails(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsBodegas As New DataSet
            Dim Details As New BodegasDetails

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM Bodegas WHERE CODIGO_Bodega = " & Codigo & " AND Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsBodegas, "Bodegas")

            If dsBodegas.Tables("Bodegas").Rows.Count = 1 Then
                Details.Codigo = dsBodegas.Tables("Bodegas").Rows(0).Item("Codigo_Bodega")
                Details.Ubicacion = dsBodegas.Tables("Bodegas").Rows(0).Item("Ubicacion")
                Details.Encargado = IsNull(dsBodegas.Tables("Bodegas").Rows(0).Item("Encargado"), "")
                Details.Cuenta_Inventario = dsBodegas.Tables("Bodegas").Rows(0).Item("cta_inventario")
                Details.CapacidadM3 = dsBodegas.Tables("Bodegas").Rows(0).Item("capacidadm3")
                Details.Exigir_Facturacion = dsBodegas.Tables("Bodegas").Rows(0).Item("Exigir_Facturacion")

                Details.Sucursal = dsBodegas.Tables("Bodegas").Rows(0).Item("Sucursal")
                Details.Gte_Ventas = dsBodegas.Tables("Bodegas").Rows(0).Item("Gerente_Ventas")
                Details.Gte_Mercadeo = dsBodegas.Tables("Bodegas").Rows(0).Item("Gerente_Mercadeo")
                Details.Gte_Sucursal = dsBodegas.Tables("Bodegas").Rows(0).Item("Gerente_Sucursal")
                Details.Tecnico = dsBodegas.Tables("Bodegas").Rows(0).Item("Tecnico")
                Details.Fact_Sin_Existencia = dsBodegas.Tables("Bodegas").Rows(0).Item("Fact_sin_Existencia")
                Details.Advertencia = dsBodegas.Tables("Bodegas").Rows(0).Item("Advertencia")
            End If

            Return Details

        End Function

        Public Function GetList() As DataTable

            Return ObtieneDatos("JAR_GetBodegasList", EmpresaActual)

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet

            'Dim conexion As New VB.SysContab.Rutinas
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT Codigo_Bodega AS [CODIGO],Codigo_Bodega + ' - ' + Ubicacion AS [UBICACION]," & _
            '                               "IsNull(Emp_PNombre + ' ' + Emp_SNombre + ' ' + Emp_PApellido + ' ' + Emp_SApellido,Encargado) AS ENCARGADO," & _
            '                               "capacidadm3 [CAPACIDAD M3], CAST(Exigir_Facturacion AS BIT) [EXIGIR EN FACTURACION]," & _
            '                               "SUCURSAL, Gerente_Ventas [GTE.VENTAS], Gerente_Mercadeo [GTE.MERCADEO], Gerente_Sucursal [GTE.SUCURSAL], TECNICO, " & _
            '                               "CAST(Fact_sin_Existencia AS BIT) [FACT SIN EXISTENCIA], " & _
            '                               "CAST(Advertencia AS BIT) [ADVERTENCIA EXISTENCIA] " & _
            '                               "FROM BODEGAS left outer JOIN EMPLEADOS ON BODEGAS.ENCARGADO = EMPLEADOS.Emp_Codigo " & _
            '                               "AND Bodegas.Empresa = Empleados.Empr_Codigo Where BODEGAS.Empresa ='" & EmpresaActual & "'", DBConn)
            'DBCommand.Fill(dsFicha, "Bodegas")

            'DBConn.Close()

            'Return dsFicha

        End Function

        Public Function Lista() As DataTable
            Return ObtieneDatos("sp_Bodegas_Lista", EmpresaActual)
        End Function

        Public Function GetListNuevo() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM Bodegas ORDER BY Codigo_Bodega DESC", DBConn)
            DBCommand.Fill(dsFicha, "Bodegas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet            

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo_Bodega AS [CODIGO ], Ubicacion AS [UBICACION], ENCARGADO FROM Bodegas WHERE Codigo_Bodega Like '%" & Filtro & "%' AND Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "Bodegas")
            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GetListBuscarCombo(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT CODIGO_Bodega, Ubicacion FROM Bodegas WHERE Codigo_Bodega Like '" & Filtro & "%' AND Empresa = '" & EmpresaActual & "' ORDER BY NOMBRE", DBConn)
            DBCommand.Fill(dsFicha, "Bodegas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListNombre(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT CODIGO_Bodega, Ubicacion FROM Bodegas WHERE Codigo_Bodega = '" & Filtro & "' AND Empresa ='" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "Bodegas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function AddItem(ByVal Codigo As String, ByVal Ubicacion As String, ByVal Encargado As String, _
                ByVal ctaInventario As String, ByVal Capacidad As Double, ByVal Exigir_Facturacion As Integer, _
                Sucursal As String, Gte_Ventas As String, Gte_Mercadeo As String, Gte_Sucursal As String, _
                Tecnico As String, Fact_Sin_Existencia As Integer, Advertencia As Integer)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Bodegas(Codigo_Bodega, Ubicacion, Encargado, Empresa, cta_Inventario, capacidadm3,Exigir_Facturacion,Sucursal,Gerente_Ventas,Gerente_Mercadeo,Gerente_Sucursal,Tecnico,Fact_sin_Existencia,Advertencia) " & _
                        "Values(" & "'" & Codigo & "','" & Ubicacion & "','" & Encargado & "','" & EmpresaActual & "','" & ctaInventario & "','" & Capacidad & "'," & Exigir_Facturacion & ",'" & IsNull(Sucursal, "") & "','" & Gte_Ventas & "','" & Gte_Mercadeo & "','" & Gte_Sucursal & "','" & Tecnico & "'," & Fact_Sin_Existencia & "," & Advertencia & ")"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()
        End Function

        Public Function Update(ByVal Codigo As String, ByVal Ubicacion As String, ByVal Encargado As String, _
            ByVal CtaInventario As String, ByVal Capacidad As Double, ByVal Exigir_Facturacion As Integer, _
            Sucursal As String, Gte_Ventas As String, Gte_Mercadeo As String, Gte_Sucursal As String, _
            Tecnico As String, Fact_Sin_Existencia As Integer, Advertencia As Integer)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE Bodegas SET Ubicacion = '" & Ubicacion & "'," & _
                "Encargado = '" & Encargado & "', cta_Inventario = '" & CtaInventario & "'," & _
                "capacidadm3 = '" & Capacidad & "', Exigir_Facturacion = " & Exigir_Facturacion & "," & _
                "Sucursal = '" & Sucursal & "', " & _
                "Gerente_Ventas = '" & Gte_Ventas & "', " & _
                "Gerente_Mercadeo = '" & Gte_Mercadeo & "', " & _
                "Gerente_Sucursal = '" & Gte_Sucursal & "', " & _
                "Tecnico = '" & Tecnico & "', " & _
                "Fact_sin_Existencia = " & Fact_Sin_Existencia & ", " & _
                "Advertencia = " & Advertencia & " " & _
                " WHERE Codigo_Bodega = '" & Codigo & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function Delete(ByVal Codigo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM Bodegas WHERE Codigo_Bodega = '" & Codigo & "' AND Empresa ='" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            Try
                cmd.Connection = DBConn
                DBConn.Open()
                cmd.ExecuteNonQuery()
            Catch EXC As Exception
                MsgBox(EXC.Message)
            End Try
            DBConn.Close()

        End Function

        'Funcion para buscar el nuevo codigo de transaccion de bodega
        Public Shared Function GetDocumento_CodigoNuevo(ByVal TipoDocumento As String) As String
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlCommand

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlCommand("_GetDocumentoBodega_CodigoNuevo", DBConn)

            DBCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.Parameters.Add(pEmpresa)

            Dim pCuenta As New SqlParameter("@Documento", SqlDbType.NVarChar, 1)
            pCuenta.Value = TipoDocumento
            DBCommand.Parameters.Add(pCuenta)

            Dim pTipo As New SqlParameter("@Codigo", SqlDbType.NVarChar, 50)
            pTipo.Value = ""
            pTipo.Direction = ParameterDirection.Output
            DBCommand.Parameters.Add(pTipo)

            Try
                DBConn.Open()
                DBCommand.ExecuteNonQuery()
                DBConn.Close()
                Return pTipo.Value

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Contab")
                Return "-1"
            End Try

        End Function

        'Sacar todos los articulos filtrados por bodega o por articulo si es necesario
        Public Shared Sub GetList_ArticulosBodega(ByVal Bodega As String, ByVal Articulo As String, _
                ByRef DS As DataSet, ByVal ARTICULO_TIPO As String, ByVal Filtro As String, _
        ByVal FiltroNombre As String)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetList_ArticulosBodega", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim pBodega As New SqlParameter("@Bodega", SqlDbType.NVarChar)
            pBodega.Value = Bodega
            DBCommand.SelectCommand.Parameters.Add(pBodega)

            Dim pArticulo As New SqlParameter("@Articulo", SqlDbType.NVarChar)
            pArticulo.Value = Articulo
            DBCommand.SelectCommand.Parameters.Add(pArticulo)

            Dim pArticulo_tipo As New SqlParameter("@Articulo_tipo", SqlDbType.NVarChar)
            pArticulo_tipo.Value = ARTICULO_TIPO
            DBCommand.SelectCommand.Parameters.Add(pArticulo_tipo)

            Dim pFiltro As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            pFiltro.Value = Filtro
            DBCommand.SelectCommand.Parameters.Add(pFiltro)

            Dim pFiltroNombre As New SqlParameter("@FiltroNombre", SqlDbType.NVarChar)
            pFiltroNombre.Value = FiltroNombre
            DBCommand.SelectCommand.Parameters.Add(pFiltroNombre)

            Try
                DBCommand.Fill(DS, "Articulos")
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Contab")
            End Try

        End Sub

        Public Shared Sub CargaInventarioBodega(ByVal Bodega As String, ByRef DS As DataSet, _
                ByVal Articulo_tipo As String, ByVal Filtro As String, ByVal FiltroNombre As String)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CargaInventarioBodega", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim pBodega As New SqlParameter("@Bodega", SqlDbType.NVarChar)
            pBodega.Value = Bodega
            DBCommand.SelectCommand.Parameters.Add(pBodega)

            Dim pArticulo_tipo As New SqlParameter("@Articulo_tipo", SqlDbType.NVarChar)
            pArticulo_tipo.Value = Articulo_tipo
            DBCommand.SelectCommand.Parameters.Add(pArticulo_tipo)

            Dim pFiltro As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            pFiltro.Value = Filtro
            DBCommand.SelectCommand.Parameters.Add(pFiltro)

            Dim pFiltroNombre As New SqlParameter("@FiltroNombre", SqlDbType.NVarChar)
            pFiltroNombre.Value = FiltroNombre
            DBCommand.SelectCommand.Parameters.Add(pFiltroNombre)

            Try
                DBCommand.Fill(DS, "Articulos")
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Contab")
            End Try

        End Sub

        'Funcion para agregar una transaccion de bodega (Encabezado)
        Public Shared Sub TransaccionBodega_Add(ByVal Bodega As String, ByVal TipoDocumento As String, _
                ByVal Documento As String, ByVal Fecha As Date, ByVal Proveedor As Integer)

            Dim DBCommand As SqlCommand

            DBCommand = New SqlCommand("_Transaccion_Bodega_Add", DBConnFacturas)
            DBCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.Parameters.Add(pEmpresa)

            Dim pBodega As New SqlParameter("@Bodega", SqlDbType.NVarChar)
            pBodega.Value = Bodega
            DBCommand.Parameters.Add(pBodega)

            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            pTipo.Value = TipoDocumento
            DBCommand.Parameters.Add(pTipo)

            Dim pDocumento As New SqlParameter("@Documento", SqlDbType.NVarChar)
            pDocumento.Value = Documento
            DBCommand.Parameters.Add(pDocumento)

            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            pFecha.Value = Fecha
            DBCommand.Parameters.Add(pFecha)

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            pProveedor.Value = Proveedor
            DBCommand.Parameters.Add(pProveedor)

            DBCommand.CommandTimeout = 0
            DBCommand.Connection = DBConnFacturas
            DBCommand.Transaction = transaccionFacturas
            DBCommand.ExecuteNonQuery()

        End Sub

        'Funcion para agregar una transaccion de bodega para Transferencias (Encabezado)
        Public Shared Sub TransaccionBodega_Add(ByVal Bodega As String, ByVal TipoDocumento As String, _
                ByVal Fecha As Date, ByVal BodegaRef As String, ByRef cSalida As String, ByRef cEntrada As String)

            Dim DBCommand As SqlCommand

            DBCommand = New SqlCommand("_Transaccion_Bodega_TransferenciasAdd", DBConnFacturas)
            DBCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.Parameters.Add(pEmpresa)

            Dim pBodega As New SqlParameter("@Bodega", SqlDbType.NVarChar)
            pBodega.Value = Bodega
            DBCommand.Parameters.Add(pBodega)

            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            pTipo.Value = TipoDocumento
            DBCommand.Parameters.Add(pTipo)

            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            pFecha.Value = Fecha
            DBCommand.Parameters.Add(pFecha)

            Dim pBodegaRef As New SqlParameter("@BodegaRef", SqlDbType.NVarChar)
            pBodegaRef.Value = BodegaRef
            DBCommand.Parameters.Add(pBodegaRef)

            Dim pcSalida As New SqlParameter("@cSalida", SqlDbType.NVarChar, 50)
            pcSalida.Direction = ParameterDirection.Output
            DBCommand.Parameters.Add(pcSalida)

            Dim pcEntrada As New SqlParameter("@cEntrada", SqlDbType.NVarChar, 50)
            pcEntrada.Direction = ParameterDirection.Output
            DBCommand.Parameters.Add(pcEntrada)


            DBCommand.Connection = DBConnFacturas
            DBCommand.Transaction = transaccionFacturas
            DBCommand.ExecuteNonQuery()
            cSalida = pcSalida.Value
            cEntrada = pcEntrada.Value
        End Sub

        'Funcion para buscar el nuevo codigo de transaccion de bodega detalle
        Public Shared Sub TransaccionBodegaDetalle_Add(ByVal Bodega As String, ByVal Articulo As String, _
                ByVal TipoDocumento As String, ByVal Documento As String, ByVal Movimiento As String, _
                ByVal Existencia As Double, ByVal Costo As Double, ByVal Proveedor As Integer, _
        ByVal Articulo_tipo As String)

            'Dim DBConn As SqlConnection
            Dim DBCommand As SqlCommand

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())
            'Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasUpdateEstado", DBConnFacturas)

            DBCommand = New SqlCommand("_Transaccion_Bodega_Detalle_Add", DBConnFacturas)
            DBCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.Parameters.Add(pEmpresa)

            Dim pBodega As New SqlParameter("@Bodega", SqlDbType.NVarChar)
            pBodega.Value = Bodega
            DBCommand.Parameters.Add(pBodega)

            Dim pArticulo As New SqlParameter("@Articulo", SqlDbType.NVarChar)
            pArticulo.Value = Articulo
            DBCommand.Parameters.Add(pArticulo)

            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            pTipo.Value = TipoDocumento
            DBCommand.Parameters.Add(pTipo)

            Dim pDocumento As New SqlParameter("@Documento", SqlDbType.NVarChar)
            pDocumento.Value = Documento
            DBCommand.Parameters.Add(pDocumento)

            Dim pMovimiento As New SqlParameter("@Movimiento", SqlDbType.NVarChar)
            pMovimiento.Value = Movimiento
            DBCommand.Parameters.Add(pMovimiento)

            Dim pExistencia As New SqlParameter("@Existencia", SqlDbType.Float)
            pExistencia.Value = Existencia
            DBCommand.Parameters.Add(pExistencia)

            Dim pCosto As New SqlParameter("@Costo", SqlDbType.Money)
            pCosto.Value = Costo
            DBCommand.Parameters.Add(pCosto)

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            pProveedor.Value = Proveedor
            DBCommand.Parameters.Add(pProveedor)

            Dim pArticulo_tipo As New SqlParameter("@Articulo_tipo", SqlDbType.NVarChar)
            pArticulo_tipo.Value = Articulo_tipo
            DBCommand.Parameters.Add(pArticulo_tipo)

            DBCommand.CommandTimeout = 0
            DBCommand.Connection = DBConnFacturas
            DBCommand.Transaction = transaccionFacturas
            DBCommand.ExecuteNonQuery()

        End Sub

        Public Shared Sub Bodega_Articulos_Add(ByVal Bodega As String, ByVal Articulo As String, _
                ByVal Existencia As Double, ByVal Costo As Double, ByVal Articulo_Tipo As String, _
                 Optional ByVal Devolucion As Integer = 0)

            'Dim DBConn As SqlConnection
            Dim DBCommand As SqlCommand

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())
            'Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasUpdateEstado", DBConnFacturas)

            DBCommand = New SqlCommand("_Bodega_Articulos_Add", DBConnFacturas)
            DBCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.Parameters.Add(pEmpresa)

            Dim pBodega As New SqlParameter("@Bodega", SqlDbType.NVarChar)
            pBodega.Value = Bodega
            DBCommand.Parameters.Add(pBodega)

            Dim pArticulo As New SqlParameter("@Articulo", SqlDbType.NVarChar)
            pArticulo.Value = Articulo
            DBCommand.Parameters.Add(pArticulo)

            Dim pExistencia As New SqlParameter("@Existencia", SqlDbType.Float)
            pExistencia.Value = Existencia
            DBCommand.Parameters.Add(pExistencia)

            Dim pCosto As New SqlParameter("@Costo", SqlDbType.Money)
            pCosto.Value = Costo
            DBCommand.Parameters.Add(pCosto)

            Dim pArticulo_tipo As New SqlParameter("@Articulo_tipo", SqlDbType.NVarChar)
            pArticulo_tipo.Value = Articulo_Tipo
            DBCommand.Parameters.Add(pArticulo_tipo)

            Dim pDevolucion As New SqlParameter("@Devolucion", SqlDbType.Int)
            pDevolucion.Value = Devolucion
            DBCommand.Parameters.Add(pDevolucion)

            DBCommand.CommandTimeout = 0
            DBCommand.Connection = DBConnFacturas
            DBCommand.Transaction = transaccionFacturas
            DBCommand.ExecuteNonQuery()
        End Sub

        'Funcion para agregar Inventario Fisico (Encabezado)
        Public Shared Sub InventarioFisico_Add(ByVal Bodega As String, ByVal Fecha As Date, _
            ByVal RealizadoPor As String, ByVal Origen As String)

            Dim DBCommand As SqlCommand

            DBCommand = New SqlCommand("_Inventario_Fisico_ADD", DBConnFacturas)
            DBCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.Parameters.Add(pEmpresa)

            Dim pBodega As New SqlParameter("@Bodega", SqlDbType.NVarChar)
            pBodega.Value = Bodega
            DBCommand.Parameters.Add(pBodega)

            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            pFecha.Value = Fecha
            DBCommand.Parameters.Add(pFecha)

            Dim pRealizadoPor As New SqlParameter("@RealizadoPor", SqlDbType.NVarChar)
            pRealizadoPor.Value = RealizadoPor
            DBCommand.Parameters.Add(pRealizadoPor)

            Dim pOrigen As New SqlParameter("@Origen", SqlDbType.NVarChar)
            pOrigen.Value = Origen
            DBCommand.Parameters.Add(pOrigen)


            DBCommand.Connection = DBConnFacturas
            DBCommand.Transaction = transaccionFacturas
            DBCommand.ExecuteNonQuery()

        End Sub

        'Funcion para agregar Inventario Fisico (Detalle)
        Public Shared Sub InventarioFisicoDetalle_Add(ByVal Bodega As String, ByVal Fecha As Date, _
            ByVal Articulo As String, ByVal Existencias As Double, ByVal Fisico As Double, ByVal Diferencias As Double, _
            ByVal Justificar As Integer, ByVal Comentarios As String, ByVal ArticuloTipo As String)

            Dim DBCommand As SqlCommand

            DBCommand = New SqlCommand("_Inventario_Fisico_Detalle_ADD", DBConnFacturas)
            DBCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.Parameters.Add(pEmpresa)

            Dim pBodega As New SqlParameter("@Bodega", SqlDbType.NVarChar)
            pBodega.Value = Bodega
            DBCommand.Parameters.Add(pBodega)

            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            pFecha.Value = Fecha
            DBCommand.Parameters.Add(pFecha)

            Dim pArticulo As New SqlParameter("@Articulo", SqlDbType.NVarChar)
            pArticulo.Value = Articulo
            DBCommand.Parameters.Add(pArticulo)

            Dim pArticuloTipo As New SqlParameter("@Articulo_Tipo", SqlDbType.NVarChar)
            pArticuloTipo.Value = ArticuloTipo
            DBCommand.Parameters.Add(pArticuloTipo)

            Dim pExistencias As New SqlParameter("@Existencias", SqlDbType.Float)
            pExistencias.Value = Existencias
            DBCommand.Parameters.Add(pExistencias)

            Dim pFisico As New SqlParameter("@Fisico", SqlDbType.Float)
            pFisico.Value = Fisico
            DBCommand.Parameters.Add(pFisico)

            Dim pDiferencias As New SqlParameter("@Diferencias", SqlDbType.Float)
            pDiferencias.Value = Diferencias
            DBCommand.Parameters.Add(pDiferencias)

            Dim pJustificar As New SqlParameter("@Justificar", SqlDbType.Int)
            pJustificar.Value = Justificar
            DBCommand.Parameters.Add(pJustificar)

            Dim pComentarios As New SqlParameter("@Comentarios", SqlDbType.Text)
            pComentarios.Value = Comentarios
            DBCommand.Parameters.Add(pComentarios)

            DBCommand.Connection = DBConnFacturas
            DBCommand.Transaction = transaccionFacturas
            DBCommand.ExecuteNonQuery()

        End Sub

        'Autorizar un encabezado de Inventario Fisico
        Public Shared Sub InventarioFisico_Autorizar(ByVal Bodega As String, ByVal Fecha As Date, ByVal Autorizado As Boolean, _
            ByVal AutorizadoPor As String, ByVal Documento As String)

            Dim DBCommand As SqlCommand

            DBCommand = New SqlCommand("_Inventario_Fisico_Autorizar", DBConnFacturas)
            DBCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.Parameters.Add(pEmpresa)

            Dim pBodega As New SqlParameter("@Bodega", SqlDbType.NVarChar)
            pBodega.Value = Bodega
            DBCommand.Parameters.Add(pBodega)

            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            pFecha.Value = Fecha
            DBCommand.Parameters.Add(pFecha)

            Dim pAutorizado As New SqlParameter("@Autorizado", SqlDbType.Bit)
            pAutorizado.Value = Autorizado
            DBCommand.Parameters.Add(pAutorizado)

            Dim pAutorizadoPor As New SqlParameter("@AutorizadoPor", SqlDbType.NVarChar)
            pAutorizadoPor.Value = AutorizadoPor
            DBCommand.Parameters.Add(pAutorizadoPor)

            Dim pDocumento As New SqlParameter("@Documento", SqlDbType.NVarChar)
            pDocumento.Value = Documento
            DBCommand.Parameters.Add(pDocumento)

            DBCommand.Connection = DBConnFacturas
            DBCommand.Transaction = transaccionFacturas
            DBCommand.ExecuteNonQuery()

        End Sub

        'Actualizar el detalle de un inventario Fisico
        Public Shared Sub InventarioFisicoDetalle_UpdateJustificacion(ByVal Bodega As String, ByVal Fecha As Date, _
           ByVal Articulo As String, ByVal Fisico As Double, ByVal Diferencias As Double, _
           ByVal Justificar As Integer, ByVal ComentariosJustificar As String)

            Dim DBCommand As SqlCommand

            DBCommand = New SqlCommand("_Inventario_Fisico_Detalle_UpdateJustificacion", DBConnFacturas)
            DBCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.Parameters.Add(pEmpresa)

            Dim pBodega As New SqlParameter("@Bodega", SqlDbType.NVarChar)
            pBodega.Value = Bodega
            DBCommand.Parameters.Add(pBodega)

            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            pFecha.Value = Fecha
            DBCommand.Parameters.Add(pFecha)

            Dim pArticulo As New SqlParameter("@Articulo", SqlDbType.NVarChar)
            pArticulo.Value = Articulo
            DBCommand.Parameters.Add(pArticulo)

            Dim pFisico As New SqlParameter("@Fisico", SqlDbType.Float)
            pFisico.Value = Fisico
            DBCommand.Parameters.Add(pFisico)

            Dim pDiferencias As New SqlParameter("@Diferencias", SqlDbType.Float)
            pDiferencias.Value = Diferencias
            DBCommand.Parameters.Add(pDiferencias)

            Dim pJustificar As New SqlParameter("@Justificar", SqlDbType.Bit)
            pJustificar.Value = Justificar
            DBCommand.Parameters.Add(pJustificar)

            Dim pComentarios As New SqlParameter("@Comentarios_Justificar", SqlDbType.Text)
            pComentarios.Value = ComentariosJustificar
            DBCommand.Parameters.Add(pComentarios)

            DBCommand.Connection = DBConnFacturas
            DBCommand.Transaction = transaccionFacturas
            DBCommand.ExecuteNonQuery()

        End Sub

        'Borrar el detalle de un inventario Fisico
        Public Shared Sub InventarioFisicoDetalle_Delete(ByVal Bodega As String, ByVal Fecha As Date)

            Dim DBCommand As SqlCommand

            DBCommand = New SqlCommand("_Inventario_Fisico_Detalle_Delete", DBConnFacturas)
            DBCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.Parameters.Add(pEmpresa)

            Dim pBodega As New SqlParameter("@Bodega", SqlDbType.NVarChar)
            pBodega.Value = Bodega
            DBCommand.Parameters.Add(pBodega)

            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            pFecha.Value = Fecha
            DBCommand.Parameters.Add(pFecha)

            DBCommand.Connection = DBConnFacturas
            DBCommand.Transaction = transaccionFacturas
            DBCommand.ExecuteNonQuery()

        End Sub

        'Borrar un inventario Fisico
        Public Shared Sub InventarioFisico_Delete(ByVal Bodega As String, ByVal Fecha As Date)

            Dim DBCommand As SqlCommand

            DBCommand = New SqlCommand("_Inventario_Fisico_Delete", DBConnFacturas)
            DBCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.Parameters.Add(pEmpresa)

            Dim pBodega As New SqlParameter("@Bodega", SqlDbType.NVarChar)
            pBodega.Value = Bodega
            DBCommand.Parameters.Add(pBodega)

            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            pFecha.Value = Fecha
            DBCommand.Parameters.Add(pFecha)

            DBCommand.Connection = DBConnFacturas
            DBCommand.Transaction = transaccionFacturas
            DBCommand.ExecuteNonQuery()

        End Sub

        'Actualizar el detalle de un inventario Fisico
        Public Shared Sub InventarioFisicoDetalle_Update(ByVal Bodega As String, ByVal Fecha As Date, _
           ByVal Articulo As String, ByVal Fisico As Double, ByVal Diferencias As Double, _
           ByVal Justificar As Integer, ByVal Comentarios As String)

            Dim DBCommand As SqlCommand

            DBCommand = New SqlCommand("_Inventario_Fisico_Detalle_Update", DBConnFacturas)
            DBCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.Parameters.Add(pEmpresa)

            Dim pBodega As New SqlParameter("@Bodega", SqlDbType.NVarChar)
            pBodega.Value = Bodega
            DBCommand.Parameters.Add(pBodega)

            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            pFecha.Value = Fecha
            DBCommand.Parameters.Add(pFecha)

            Dim pArticulo As New SqlParameter("@Articulo", SqlDbType.NVarChar)
            pArticulo.Value = Articulo
            DBCommand.Parameters.Add(pArticulo)

            Dim pFisico As New SqlParameter("@Fisico", SqlDbType.Float)
            pFisico.Value = Fisico
            DBCommand.Parameters.Add(pFisico)

            Dim pDiferencias As New SqlParameter("@Diferencias", SqlDbType.Float)
            pDiferencias.Value = Diferencias
            DBCommand.Parameters.Add(pDiferencias)

            Dim pJustificar As New SqlParameter("@Justificar", SqlDbType.Bit)
            pJustificar.Value = Justificar
            DBCommand.Parameters.Add(pJustificar)

            Dim pComentarios As New SqlParameter("@Comentarios", SqlDbType.Text)
            pComentarios.Value = Comentarios
            DBCommand.Parameters.Add(pComentarios)

            DBCommand.Connection = DBConnFacturas
            DBCommand.Transaction = transaccionFacturas
            DBCommand.ExecuteNonQuery()

        End Sub
        'Funcion para consultar una transaccion de Inventario Fisico (Encabezado)
        Public Shared Function GetList_InventarioFisico(ByVal Bodega As String, ByVal Fecha As Date) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet


            DBCommand = New SqlDataAdapter("_GetListInventario_fisico", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim pBodega As New SqlParameter("@Bodega", SqlDbType.NVarChar)
            pBodega.Value = Bodega
            DBCommand.SelectCommand.Parameters.Add(pBodega)

            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            pFecha.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(pFecha)

            Try
                DBConn.Open()
                DBCommand.Fill(dsFicha, "EncabezadoInventarioFisico")
                DBConn.Close()
                Return dsFicha
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Contab")
                Return Nothing
            End Try

        End Function

        'Funcion para consultar las transacciones de Inventario Fisico (Encabezado)
        Public Shared Function GetList_InventarioFisico(ByVal Filtro As String, ByVal Bodega As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            DBConn = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)
            DBCommand = New SqlDataAdapter("_GetListInventario_fisico_Filtro", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim pFiltro As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            pFiltro.Value = Filtro
            DBCommand.SelectCommand.Parameters.Add(pFiltro)

            Dim pBodega As New SqlParameter("@Bodega", SqlDbType.NVarChar)
            pBodega.Value = Bodega
            DBCommand.SelectCommand.Parameters.Add(pBodega)

            Try
                DBConn.Open()
                DBCommand.Fill(dsFicha, "InventarioFisico")
                DBConn.Close()
                Return dsFicha
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Contab")
                Return Nothing
            End Try

        End Function
        'Funcion para consultar una transaccion de Inventario Fisico (Detale)
        Public Shared Function GetList_InventarioFisico_Detalle(ByVal Bodega As String, _
            ByVal Fecha As Date, ByRef dsficha As DataSet, ByVal TipoArticulo As String) 'As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)
            DBCommand = New SqlDataAdapter("_GetListInventario_fisico_Detalle", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim pBodega As New SqlParameter("@Bodega", SqlDbType.NVarChar)
            pBodega.Value = Bodega
            DBCommand.SelectCommand.Parameters.Add(pBodega)

            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            pFecha.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(pFecha)

            Dim pTipoArticulo As New SqlParameter("@ArticuloTipo", SqlDbType.NVarChar)
            pTipoArticulo.Value = TipoArticulo
            DBCommand.SelectCommand.Parameters.Add(pTipoArticulo)

            Try
                DBConn.Open()
                DBCommand.Fill(dsficha, "Articulos")
                DBConn.Close()
                'Return dsFicha
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Contab")
                'Return Nothing
            End Try

        End Function

        'Funcion actualizar la existencia de un articulo en una bodega
        ''Public Shared Sub UpdateExistenciaBodegaArticulo(ByVal Bodega As String, ByVal Articulo As String, _
        ''                       ByVal Existencia As Double, ByVal Costo As Double)

        ''    Dim DBConn As SqlConnection
        ''    Dim DBCommand As SqlCommand

        ''    Dim conexion As New VB.SysContab.Rutinas()
        ''    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        ''    DBCommand = New SqlCommand("_Transaccion_Bodega_Detalle_Add", DBConn)
        ''    DBCommand.CommandType = CommandType.StoredProcedure

        ''    Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
        ''    pEmpresa.Value = EmpresaActual
        ''    DBCommand.Parameters.Add(pEmpresa)

        ''    Dim pBodega As New SqlParameter("@Bodega", SqlDbType.NVarChar)
        ''    pBodega.Value = Bodega
        ''    DBCommand.Parameters.Add(pBodega)

        ''    Dim pArticulo As New SqlParameter("@Articulo", SqlDbType.NVarChar)
        ''    pArticulo.Value = Articulo
        ''    DBCommand.Parameters.Add(pArticulo)

        ''    Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
        ''    pTipo.Value = TipoDocumento
        ''    DBCommand.Parameters.Add(pTipo)

        ''    Dim pDocumento As New SqlParameter("@Documento", SqlDbType.NVarChar)
        ''    pDocumento.Value = Documento
        ''    DBCommand.Parameters.Add(pDocumento)

        ''    Dim pMovimiento As New SqlParameter("@Movimiento", SqlDbType.NVarChar)
        ''    pMovimiento.Value = Movimiento
        ''    DBCommand.Parameters.Add(pMovimiento)

        ''    Dim pExistencia As New SqlParameter("@Existencia", SqlDbType.Float)
        ''    pExistencia.Value = Existencia
        ''    DBCommand.Parameters.Add(pExistencia)

        ''    Dim pCosto As New SqlParameter("@Costo", SqlDbType.Money)
        ''    pCosto.Value = Costo
        ''    DBCommand.Parameters.Add(pCosto)

        ''    Try
        ''        DBConn.Open()
        ''        DBCommand.ExecuteNonQuery()
        ''        DBConn.Close()
        ''    Catch ex As Exception
        ''        MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Contab")
        ''    End Try

        ''End Sub
    End Class

End Namespace