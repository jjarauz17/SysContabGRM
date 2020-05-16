Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class Activo_FijoPropiedad
        Public Registro_Catastral As String
        Public Escritura As String
        Public Fecha_Escritura As String
        Public Registro As String
        Public Tomo As String
        Public Folio As String
    End Class
    Public Class Activo_FijoVehiculo
        Public Motor As String
        Public Chasis As String
        Public Marca As String
        Public Modelo As String
        Public TipoAuto As String
        Public Color As String
        Public Placa As String
        Public Año As String
    End Class
    Public Class Activo_FijoArticulo
        Public Codigo_Barra As String
        Public Unidad As String
    End Class
    Public Class Activo_FijosDetails
        Public Codigo As String
        Public Descripcion As String
        Public Precio As String
        Public Valor_Libros As String
        Public Grupo_Depreciacion As String
        Public Cuenta_Gastos As String
        Public Cuenta_Depreciacion As String
        Public Empleado As String
        Public Fecha_Entrada As Date
        Public Estado As String
        Public Situacion As String
        Public Tipo As String
        Public Comentarios As String
        Public Proveedor As String
        Public Factura As String
        Public PropiedadDetail As New VB.SysContab.Activo_FijoPropiedad
        Public VehiculoDetail As New VB.SysContab.Activo_FijoVehiculo
        Public ArticuloDetail As New VB.SysContab.Activo_FijoArticulo
    End Class
    Public Class Activo_Fijo_Baja
        Public Empresa As String
        Public Codigo_Activo As String
        Public Fecha_Baja As String
        Public Empleado As String
        Public Motivo As String
        Public Fecha_Perdida As String
        Public Documentos As String
    End Class

    Public Class Articulos_AFijoDetails
        Public Codigo As String
        Public Nombre As String
        Public Proveedor As String
        Public Linea As String
        Public Grupo As String
        Public SubGrupo As String
        Public Modelo As String
        Public Unidad As String
        Public Presentacion As String
        Public Ubicacion As String
        Public Precio_Venta_Cordobas As String
        Public Precio_Venta_Dolar As String
        Public Costo As String
        Public Margen As String
        Public Costo_Prom As String
        Public Costo_Ultimo As String
        Public Existencia As String
        Public Stock_Min As String
        Public Stock_Max As String
        Public Descuento_A As String
        Public Descuento_B As String
        Public Descuento_C As String
        Public Descuento_Maximo As String
        Public Tasa_Cambio As String
        Public Tipo As String
        Public Exento As String
        Public Cuenta As String

    End Class
    Public Class Articulos_AFijoDB

        Public Shared Function GetRegistroActivoFijo(ByRef dsficha As DataSet, ByVal Factura As String, ByVal Proveedor As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasComprasDetalle_RegistrarAfijo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pProveedor.Value = Proveedor
            pEmpresa.Value = EmpresaActual


            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Compras")

            DBConn.Close()

            Return dsFicha

        End Function
        Public Shared Function ArticulosBuscar(ByVal Filtro As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosBuscar_afijo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFiltro As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFiltro.Value = Filtro
            pTipo.Value = Tipo
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFiltro)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Articulos")

            DBConn.Close()

            Return dsFicha
        End Function
        Public Shared Function GetDetails(ByVal Codigo As String, ByVal Tipo As String, ByVal Empresa As String) As Articulos_AFijoDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsGrupo As New DataSet
            Dim Details As New Articulos_AFijoDetails

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())
            If Tipo = "%" Then
                DBCommand = New SqlDataAdapter("SELECT * FROM ARTICULOS_AFijo WHERE CODIGO_ARTICULO = '" & Codigo & "' And Empresa = '" & Empresa & "'", DBConn)
            Else
                DBCommand = New SqlDataAdapter("SELECT * FROM ARTICULOS_AFijo WHERE CODIGO_ARTICULO = '" & Codigo & "' And Empresa = '" & Empresa & "' AND Tipo = '" & Tipo & "'", DBConn)
            End If


            DBCommand.Fill(dsGrupo, "ARTICULOS")

            If dsGrupo.Tables("ARTICULOS").Rows.Count = 1 Then
                Details.Codigo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("CODIGO_ARTICULO").ToString
                Details.Nombre = dsGrupo.Tables("ARTICULOS").Rows(0).Item("NOMBRE").ToString
                Details.Proveedor = dsGrupo.Tables("ARTICULOS").Rows(0).Item("PROVEEDOR").ToString
                Details.Linea = dsGrupo.Tables("ARTICULOS").Rows(0).Item("LINEA").ToString
                Details.Grupo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("GRUPO").ToString
                Details.SubGrupo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("SUBGRUPO").ToString
                Details.Modelo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("MODELO").ToString
                Details.Unidad = dsGrupo.Tables("ARTICULOS").Rows(0).Item("UNIDAD").ToString
                Details.Presentacion = dsGrupo.Tables("ARTICULOS").Rows(0).Item("PRESENTACION").ToString
                Details.Ubicacion = dsGrupo.Tables("ARTICULOS").Rows(0).Item("UBICACION").ToString
                Details.Precio_Venta_Cordobas = dsGrupo.Tables("ARTICULOS").Rows(0).Item("PRECIO_VENTA_CORDOBAS").ToString
                Details.Precio_Venta_Dolar = dsGrupo.Tables("ARTICULOS").Rows(0).Item("PRECIO_VENTA_DOLAR").ToString
                Details.Costo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("COSTO").ToString
                Details.Margen = dsGrupo.Tables("ARTICULOS").Rows(0).Item("MARGEN").ToString
                Details.Costo_Prom = dsGrupo.Tables("ARTICULOS").Rows(0).Item("COSTO_PROM").ToString
                Details.Costo_Ultimo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("COSTO_ULTIMO").ToString
                Details.Existencia = dsGrupo.Tables("ARTICULOS").Rows(0).Item("EXISTENCIAS").ToString
                Details.Stock_Min = dsGrupo.Tables("ARTICULOS").Rows(0).Item("STOCK_MIN").ToString
                Details.Stock_Max = dsGrupo.Tables("ARTICULOS").Rows(0).Item("STOCK_MAX").ToString
                Details.Descuento_A = dsGrupo.Tables("ARTICULOS").Rows(0).Item("DESCUENTO_A").ToString
                Details.Descuento_B = dsGrupo.Tables("ARTICULOS").Rows(0).Item("DESCUENTO_B").ToString
                Details.Descuento_C = dsGrupo.Tables("ARTICULOS").Rows(0).Item("DESCUENTO_C").ToString
                Details.Descuento_Maximo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("DESCUENTO_MAXIMO").ToString
                Details.Tasa_Cambio = dsGrupo.Tables("ARTICULOS").Rows(0).Item("TASA_CAMBIO").ToString
                Details.Tipo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("TIPO").ToString
                Details.Exento = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Exento").ToString
                Details.Cuenta = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Cuenta").ToString

            End If

            Return Details

        End Function

        Public Shared Function ArticulosListAll(ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Articulos_AFijoListAll", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)

            pEmpresa.Value = EmpresaActual
            pTipo.Value = Tipo

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pTipo)

            DBCommand.Fill(dsFicha, "Articulos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function ArticulosConsulta(ByVal Codigo As String, ByVal Descripcion As String, _
                ByVal Linea As String, ByVal Proveedor As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Articulos_AfijoConsulta", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCodigo As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pDescripcion As New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Dim pLinea As New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)

            pCodigo.Value = Codigo
            pDescripcion.Value = Descripcion
            pLinea.Value = Linea
            pProveedor.Value = Proveedor
            pEmpresa.Value = EmpresaActual
            pTipo.Value = Tipo

            DBCommand.SelectCommand.Parameters.Add(pCodigo)
            DBCommand.SelectCommand.Parameters.Add(pDescripcion)
            DBCommand.SelectCommand.Parameters.Add(pLinea)
            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pTipo)

            DBCommand.Fill(dsFicha, "Articulos")

            DBConn.Close()

            Return dsFicha
        End Function
        Public Shared Function ArticulosConsultaLetra(ByVal Letra As String, ByVal Codigo As String, _
                ByVal Descripcion As String, ByVal Linea As String, ByVal Proveedor As String, _
                ByVal Estado As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Articulos_AfijoConsultaLetra", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pLetra As New SqlParameter("@Letra", SqlDbType.NVarChar)
            Dim pCodigo As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pDescripcion As New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Dim pLinea As New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)

            pLetra.Value = Letra
            pCodigo.Value = Codigo
            pDescripcion.Value = Descripcion
            pLinea.Value = Linea
            pProveedor.Value = Proveedor
            pEstado.Value = Estado
            pEmpresa.Value = EmpresaActual
            pTipo.Value = Tipo

            DBCommand.SelectCommand.Parameters.Add(pLetra)
            DBCommand.SelectCommand.Parameters.Add(pCodigo)
            DBCommand.SelectCommand.Parameters.Add(pDescripcion)
            DBCommand.SelectCommand.Parameters.Add(pLinea)
            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pTipo)

            DBCommand.Fill(dsFicha, "Articulos")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function GetListBuscar(ByVal Filtro As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT ARTICULOS.CODIGO_ARTICULO, ARTICULOS.NOMBRE AS NOMBRE, ARTICULOS.PRECIO_VENTA_CORDOBAS AS PRECIO, ARTICULOS.COSTO AS COSTO, ARTICULOS.EXISTENCIAS AS CANTIDAD, PROVEEDORES.NOMBRE AS PROVEEDOR " & _
                                           "FROM ARTICULOS_Afijo as Articulos INNER JOIN PROVEEDORES " & _
                                           "ON ARTICULOS.PROVEEDOR = PROVEEDORES.CODIGO INNER JOIN EMPRESAS " & _
                                           "ON EMPRESAS.CODIGO = ARTICULOS.EMPRESA " & _
                                           "AND EMPRESAS.CODIGO = PROVEEDORES.EMPRESA " & _
                                           "AND ARTICULOS.NOMBRE Like '%" & Filtro & "%' AND ARTICULOS.Empresa = '" & EmpresaActual & "' AND ARTICULOS.Tipo ='" & Tipo & "' ORDER BY ARTICULOS.NOMBRE", DBConn)

            DBCommand.Fill(dsFicha, "ARTICULOS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Sub Delete(ByVal Codigo As String, ByVal Tipo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM ARTICULOS_AFijo WHERE CODIGO_ARTICULO = '" & Codigo & "' And Empresa = '" & EmpresaActual & "' And Tipo = '" & Tipo & "'"

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Sub

        Public Shared Sub AddItem(ByVal Codigo As String, ByVal Nombre As String, ByVal Proveedor As String, _
                                ByVal Linea As String, ByVal Grupo As String, ByVal SubGrupo As String, ByVal Modelo As String, _
                                ByVal Unidad As String, ByVal Presentacion As String, ByVal Ubicacion As String, ByVal PVCordobas As Double, ByVal PVDolar As Double, _
                                ByVal Costo As String, ByVal Margen As String, ByVal Costo_Prom As String, ByVal Costo_Ultimo As String, ByVal Existencias As String, ByVal StockMin As String, ByVal StockMax As String, _
                                ByVal DescuentoA As String, ByVal DescuentoB As String, ByVal DescuentoC As String, _
                                ByVal DescuentoMaximo As String, ByVal Tasa_Cambio As String, ByVal Tipo As String, _
                                ByVal Exento As Boolean, ByVal Cuenta As String)

            Dim DBConn As SqlConnection
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_Articulos_AFijoAdd", DBConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim _Codigo As SqlParameter = New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim _Nombre As SqlParameter = New SqlParameter("@Nombre", SqlDbType.NVarChar)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim _Linea As SqlParameter = New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim _Grupo As SqlParameter = New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim _SubGrupo As SqlParameter = New SqlParameter("@SubGrupo", SqlDbType.NVarChar)
            Dim _Modelo As SqlParameter = New SqlParameter("@Modelo", SqlDbType.NVarChar)
            Dim _Unidad As SqlParameter = New SqlParameter("@Unidad", SqlDbType.NVarChar)
            Dim _Presentacion As SqlParameter = New SqlParameter("@Presentacion", SqlDbType.NVarChar)
            Dim _Ubicacion As SqlParameter = New SqlParameter("@Ubicacion", SqlDbType.NVarChar)
            Dim _PVCordobas As SqlParameter = New SqlParameter("@PVCordobas", SqlDbType.Float)
            Dim _PVDolar As SqlParameter = New SqlParameter("@PVDolar", SqlDbType.Float)
            Dim _Costo As SqlParameter = New SqlParameter("@Costo", SqlDbType.Float)
            Dim _Margen As SqlParameter = New SqlParameter("@Margen", SqlDbType.Float)
            Dim _CostoPromedio As SqlParameter = New SqlParameter("@CostoPromedio", SqlDbType.Float)
            Dim _CostoUltimo As SqlParameter = New SqlParameter("@CostoUltimo", SqlDbType.Float)
            Dim _Existencias As SqlParameter = New SqlParameter("@Existencias", SqlDbType.Float)
            Dim _StockMin As SqlParameter = New SqlParameter("@StockMin", SqlDbType.Float)
            Dim _StockMax As SqlParameter = New SqlParameter("@StockMax", SqlDbType.Float)
            Dim _DescuentoA As SqlParameter = New SqlParameter("@DescuentoA", SqlDbType.Float)
            Dim _DescuentoB As SqlParameter = New SqlParameter("@DescuentoB", SqlDbType.Float)
            Dim _DescuentoC As SqlParameter = New SqlParameter("@DescuentoC", SqlDbType.Float)
            Dim _DescuentoMaximo As SqlParameter = New SqlParameter("@DescuentoMaximo", SqlDbType.Float)
            Dim _Tasa_Cambio As SqlParameter = New SqlParameter("@Tasa_Cambio", SqlDbType.Float)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim _Exento As SqlParameter = New SqlParameter("@Exento", SqlDbType.Bit)
            Dim _Cuenta As SqlParameter = New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)


            _Codigo.Value = Codigo
            _Nombre.Value = Nombre
            _Proveedor.Value = Proveedor
            _Linea.Value = Linea
            _Grupo.Value = Grupo
            _SubGrupo.Value = SubGrupo
            _Modelo.Value = Modelo
            _Unidad.Value = Unidad
            _Presentacion.Value = Presentacion
            _Ubicacion.Value = Ubicacion
            _PVCordobas.Value = PVCordobas
            _PVDolar.Value = PVDolar
            _Costo.Value = Costo
            _Margen.Value = Margen
            _CostoPromedio.Value = Costo_Prom
            _CostoUltimo.Value = Costo_Ultimo
            _Existencias.Value = Existencias
            _StockMin.Value = StockMin
            _StockMax.Value = StockMax
            _DescuentoA.Value = DescuentoA
            _DescuentoB.Value = DescuentoB
            _DescuentoC.Value = DescuentoC
            _DescuentoMaximo.Value = DescuentoMaximo
            _Tasa_Cambio.Value = Tasa_Cambio
            _Tipo.Value = Tipo
            _Exento.Value = Exento
            _Cuenta.Value = Cuenta
            _Empresa.Value = EmpresaActual


            cmd.Parameters.Add(_Codigo)
            cmd.Parameters.Add(_Nombre)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_Linea)
            cmd.Parameters.Add(_Grupo)
            cmd.Parameters.Add(_SubGrupo)
            cmd.Parameters.Add(_Modelo)
            cmd.Parameters.Add(_Unidad)
            cmd.Parameters.Add(_Presentacion)
            cmd.Parameters.Add(_Ubicacion)
            cmd.Parameters.Add(_PVCordobas)
            cmd.Parameters.Add(_PVDolar)
            cmd.Parameters.Add(_Costo)
            cmd.Parameters.Add(_Margen)
            cmd.Parameters.Add(_CostoPromedio)
            cmd.Parameters.Add(_CostoUltimo)
            cmd.Parameters.Add(_Existencias)
            cmd.Parameters.Add(_StockMin)
            cmd.Parameters.Add(_StockMax)
            cmd.Parameters.Add(_DescuentoA)
            cmd.Parameters.Add(_DescuentoB)
            cmd.Parameters.Add(_DescuentoC)
            cmd.Parameters.Add(_DescuentoMaximo)
            cmd.Parameters.Add(_Tasa_Cambio)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Exento)
            cmd.Parameters.Add(_Cuenta)
            cmd.Parameters.Add(_Empresa)


            ' Open the connection and execute the Command
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()


        End Sub

        Public Shared Sub Update(ByVal Codigo As String, ByVal Nombre As String, ByVal Proveedor As String, _
                                ByVal Linea As String, ByVal Grupo As String, ByVal SubGrupo As String, ByVal Modelo As String, _
                                ByVal Unidad As String, ByVal Presentacion As String, ByVal Ubicacion As String, ByVal PVCordobas As String, ByVal PVDolar As String, _
                                ByVal Costo As String, ByVal Margen As String, ByVal Existencias As String, ByVal StockMin As String, ByVal StockMax As String, _
                                ByVal DescuentoA As String, ByVal DescuentoB As String, ByVal DescuentoC As String, _
                                ByVal DescuentoMaximo As String, ByVal Tasa_Cambio As String, ByVal Exento As String, _
                                ByVal Cuenta As String, ByVal Tipo As String)

            Dim DBConn As SqlConnection
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_Articulos_AfijoUpdate", DBConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim _Codigo As SqlParameter = New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim _Nombre As SqlParameter = New SqlParameter("@Nombre", SqlDbType.NVarChar)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim _Linea As SqlParameter = New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim _Grupo As SqlParameter = New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim _SubGrupo As SqlParameter = New SqlParameter("@SubGrupo", SqlDbType.NVarChar)
            Dim _Modelo As SqlParameter = New SqlParameter("@Modelo", SqlDbType.NVarChar)
            Dim _Unidad As SqlParameter = New SqlParameter("@Unidad", SqlDbType.NVarChar)
            Dim _Presentacion As SqlParameter = New SqlParameter("@Presentacion", SqlDbType.NVarChar)
            Dim _Ubicacion As SqlParameter = New SqlParameter("@Ubicacion", SqlDbType.NVarChar)
            Dim _PVCordobas As SqlParameter = New SqlParameter("@PVCordobas", SqlDbType.Float)
            Dim _PVDolar As SqlParameter = New SqlParameter("@PVDolar", SqlDbType.Float)
            Dim _Costo As SqlParameter = New SqlParameter("@Costo", SqlDbType.Float)
            Dim _Margen As SqlParameter = New SqlParameter("@Margen", SqlDbType.Float)
            Dim _Existencias As SqlParameter = New SqlParameter("@Existencias", SqlDbType.Float)
            Dim _StockMin As SqlParameter = New SqlParameter("@StockMin", SqlDbType.Float)
            Dim _StockMax As SqlParameter = New SqlParameter("@StockMax", SqlDbType.Float)
            Dim _DescuentoA As SqlParameter = New SqlParameter("@DescuentoA", SqlDbType.Float)
            Dim _DescuentoB As SqlParameter = New SqlParameter("@DescuentoB", SqlDbType.Float)
            Dim _DescuentoC As SqlParameter = New SqlParameter("@DescuentoC", SqlDbType.Float)
            Dim _DescuentoMaximo As SqlParameter = New SqlParameter("@DescuentoMaximo", SqlDbType.Float)
            Dim _Tasa_Cambio As SqlParameter = New SqlParameter("@Tasa_Cambio", SqlDbType.Float)
            Dim _Exento As SqlParameter = New SqlParameter("@Exento", SqlDbType.Bit)
            Dim _Cuenta As SqlParameter = New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar)

            _Codigo.Value = Codigo
            _Nombre.Value = Nombre
            _Proveedor.Value = Proveedor
            _Linea.Value = Linea
            _Grupo.Value = Grupo
            _SubGrupo.Value = SubGrupo
            _Modelo.Value = Modelo
            _Unidad.Value = Unidad
            _Presentacion.Value = Presentacion
            _Ubicacion.Value = Ubicacion
            _PVCordobas.Value = PVCordobas
            _PVDolar.Value = PVDolar
            _Costo.Value = Costo
            _Margen.Value = Margen
            _Existencias.Value = Existencias
            _StockMin.Value = StockMin
            _StockMax.Value = StockMax
            _DescuentoA.Value = DescuentoA
            _DescuentoB.Value = DescuentoB
            _DescuentoC.Value = DescuentoC
            _DescuentoMaximo.Value = DescuentoMaximo
            _Tasa_Cambio.Value = Tasa_Cambio
            _Exento.Value = Exento
            _Cuenta.Value = Cuenta
            _Empresa.Value = EmpresaActual
            _Tipo.Value = Tipo

            cmd.Parameters.Add(_Codigo)
            cmd.Parameters.Add(_Nombre)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_Linea)
            cmd.Parameters.Add(_Grupo)
            cmd.Parameters.Add(_SubGrupo)
            cmd.Parameters.Add(_Modelo)
            cmd.Parameters.Add(_Unidad)
            cmd.Parameters.Add(_Presentacion)
            cmd.Parameters.Add(_Ubicacion)
            cmd.Parameters.Add(_PVCordobas)
            cmd.Parameters.Add(_PVDolar)
            cmd.Parameters.Add(_Costo)
            cmd.Parameters.Add(_Margen)
            cmd.Parameters.Add(_Existencias)
            cmd.Parameters.Add(_StockMin)
            cmd.Parameters.Add(_StockMax)
            cmd.Parameters.Add(_DescuentoA)
            cmd.Parameters.Add(_DescuentoB)
            cmd.Parameters.Add(_DescuentoC)
            cmd.Parameters.Add(_DescuentoMaximo)
            cmd.Parameters.Add(_Tasa_Cambio)
            cmd.Parameters.Add(_Exento)
            cmd.Parameters.Add(_Cuenta)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Tipo)

            ' Open the connection and execute the Command
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Sub

        ''Para las ordenes de compra
        Public Shared Function OrdenesCompraXProveedor(ByVal Proveedor As String, ByVal Fecha As String, _
                ByVal Estado As String, ByVal Tipo As String, ByVal Origen As String, _
                ByVal Destino As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim EstadoLocal As String = ""

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_OrdenesCompraXProveedor_Afijo", DBConn)

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

            DBCommand.Fill(dsFicha, "Ordenes_Compra")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function OrdenComprasAnular(ByVal Orden As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_OrdenComprasAnular_Afijo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Orden As New SqlParameter("@Orden", SqlDbType.NVarChar)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)

            _Orden.Value = Orden
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Orden)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Ordenes_Compras")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function Numero() As Integer
            Dim cmd As SqlCommand = New SqlCommand("_OrdenesComprasNumero_Afijo", DBConnFacturas)

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

        Public Shared Function ProductosGetAll(ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosGetAll_Afijo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pTipo.Value = Tipo
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Articulos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Sub AddItem_OrdenCompra(ByVal Factura As String, ByVal Fecha As String, ByVal FechaPago As String, ByVal Proveedor As String, ByVal SubTotal As String, ByVal Iva As String, ByVal Saldo As String, ByVal FormaPago As String, ByVal Tipo As String, ByVal Origen As String, ByVal Orden As String, ByVal Temporal As String)

            Dim cmd As SqlCommand = New SqlCommand("_OrdenesComprasAdd_Afijo", DBConnFacturas)

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

        End Sub

        Public Shared Sub AddFacturaLineas_OrdenCompra(ByVal Factura As String, ByVal Item As String, ByVal Cantidad As String, _
                                        ByVal Costo As String, ByVal Descuento As String, ByVal Iva As String, ByVal Tipo As String)


            Dim cmd As SqlCommand = New SqlCommand("_OrdenesComprasLineasAdd_Afijo", DBConnFacturas)

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

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Sub

        Public Shared Function OrdenComprasDetalle(ByVal Orden As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_OrdenComprasDetalle_Afijo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Orden As New SqlParameter("@Orden", SqlDbType.NVarChar)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)

            _Orden.Value = Orden
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Orden)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Ordenes_Compras")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Sub OrdenCompraUpdate(ByVal Factura As String, ByVal Fecha As String, ByVal FechaPago As String, ByVal Proveedor As String, ByVal SubTotal As String, ByVal Iva As String, ByVal Saldo As String, ByVal FormaPago As String, ByVal Tipo As String, ByVal Origen As String, ByVal Orden As String, ByVal Temporal As String)

            Dim cmd As SqlCommand = New SqlCommand("_OrdenesComprasUpdate_Afijo", DBConnFacturas)

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

        End Sub

        Public Shared Function OrdenComprasDetalleDelete(ByVal Orden As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_OrdenComprasDetalleDelete_Afijo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Orden As New SqlParameter("@Orden", SqlDbType.NVarChar)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)

            _Orden.Value = Orden
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Orden)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Ordenes_Compras")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function OrdenCompraDetalle(ByVal Factura As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_OrdenesComprasDetalle_afijo", DBConn)

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

        Public Shared Function FacturasCompraLista(ByVal Proveedor As String, ByVal Fecha As String, _
            ByVal Fecha1 As String, ByVal Mes As String, ByVal Estado As String, _
            ByVal Tipo As String, ByVal TipoFactura As String, ByVal Origen As String, _
            ByVal Destino As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim EstadoLocal As String = ""

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasComprasLista_Afijo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pFecha As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim pFecha1 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim pTipoFactura As New SqlParameter("@TipoFactura", SqlDbType.Int)
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
            pFecha1.Value = Fecha1
            pMes.Value = Mes
            pEstado.Value = EstadoLocal
            pTipo.Value = Tipo
            pTipoFactura.Value = TipoFactura
            pOrigen.Value = Origen
            pDestino.Value = Destino
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pFecha)
            DBCommand.SelectCommand.Parameters.Add(pFecha1)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pTipoFactura)
            DBCommand.SelectCommand.Parameters.Add(pOrigen)
            DBCommand.SelectCommand.Parameters.Add(pDestino)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            'Try
            DBCommand.Fill(dsFicha, "Facturas_Compra")
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function FacturaDetalle(ByVal Factura As String, ByVal Proveedor As String, ByVal Destino As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasComprasDetalle_Afijo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pDestino As New SqlParameter("@Destino", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pProveedor.Value = Proveedor
            pDestino.Value = Destino
            pEmpresa.Value = EmpresaActual


            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pDestino)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Compras")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Sub UpdateEstado(ByVal Numero As String, ByVal Estado As String, ByVal Fecha As String, ByVal Proveedor As String)
            Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasUpdateEstado_afijo", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Numero As SqlParameter = New SqlParameter("@Numero", SqlDbType.NVarChar)
            Dim _Estado As SqlParameter = New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)

            _Numero.Value = Numero
            _Estado.Value = Estado
            _Fecha.Value = Fecha
            _Empresa.Value = EmpresaActual
            _Proveedor.Value = Proveedor

            cmd.Parameters.Add(_Numero)
            cmd.Parameters.Add(_Estado)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Proveedor)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Sub

        Public Shared Sub UpdateNumero(ByVal Factura As String, ByVal OrdenCompra As String, ByVal Proveedor As String)
            Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasUpdateNumero_Afijo", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim _OrdenCompra As SqlParameter = New SqlParameter("@OrdenCompra", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)

            _Factura.Value = Factura
            _OrdenCompra.Value = OrdenCompra
            _Empresa.Value = EmpresaActual
            _Proveedor.Value = Proveedor

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_OrdenCompra)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Proveedor)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Sub

        Public Shared Sub AddItem_Facturacompra(ByVal Factura As String, ByVal Fecha As String, ByVal FechaPago As String, ByVal Proveedor As String, ByVal Saldo As String, ByVal FormaPago As String, ByVal Tipo As String, ByVal Esquema As String, ByVal Id As String, ByVal OrdenCompra As String, ByVal Origen As String, ByVal IDTemporal As String, ByVal Observaciones As String, ByVal Estado As String)

            Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasAdd_Afijo", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim _FechaPago As SqlParameter = New SqlParameter("@FechaPago", SqlDbType.DateTime)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)
            'Dim _SubTotal As SqlParameter = New SqlParameter("@SubTotal", SqlDbType.Float, 8)
            'Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Float, 8)
            Dim _FormaPago As SqlParameter = New SqlParameter("@Forma_Pago", SqlDbType.Int, 4)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int, 4)
            Dim _Esquema As SqlParameter = New SqlParameter("@Esquema", SqlDbType.Int, 4)
            Dim _Id As SqlParameter = New SqlParameter("@ID", SqlDbType.NVarChar)
            Dim _OrdenCompra As SqlParameter = New SqlParameter("@OrdenCompra", SqlDbType.NVarChar)
            Dim _Origen As SqlParameter = New SqlParameter("@Origen", SqlDbType.Int, 4)
            Dim _Temporal As SqlParameter = New SqlParameter("@Temporal", SqlDbType.NVarChar)
            Dim _Observaciones As SqlParameter = New SqlParameter("@Observaciones", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Estado As SqlParameter = New SqlParameter("@Estado", SqlDbType.NVarChar)

            _Factura.Value = Factura
            _Fecha.Value = Fecha
            _FechaPago.Value = FechaPago
            _Proveedor.Value = Proveedor
            '_SubTotal.Value = SubTotal
            '_Iva.Value = Iva
            _Saldo.Value = Saldo
            _FormaPago.Value = FormaPago
            _Tipo.Value = Tipo
            _Esquema.Value = Esquema
            _Id.Value = Id
            _OrdenCompra.Value = OrdenCompra
            _Origen.Value = Origen
            _Temporal.Value = IDTemporal
            _Observaciones.Value = Observaciones
            _Empresa.Value = EmpresaActual
            _Estado.Value = Estado

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_FechaPago)
            cmd.Parameters.Add(_Proveedor)
            'cmd.Parameters.Add(_SubTotal)
            'cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Saldo)
            cmd.Parameters.Add(_FormaPago)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Esquema)
            cmd.Parameters.Add(_Id)
            cmd.Parameters.Add(_OrdenCompra)
            cmd.Parameters.Add(_Origen)
            cmd.Parameters.Add(_Temporal)
            cmd.Parameters.Add(_Observaciones)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Estado)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Sub
        Public Shared Sub AddFacturaLineas_FacturaCompra(ByVal Factura As String, ByVal Item As String, ByVal Cantidad As String, _
                                        ByVal Costo As String, ByVal Descuento As String, ByVal Iva As String, ByVal Tipo As String, ByVal CantidadAlmacen As String, ByVal IvaAlmacen As String, ByVal IvaPorcentaje As String, ByVal Proveedor As String)


            Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasLineasAdd_afijo", DBConnFacturas)

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
            Dim _CantidadAlmacen As SqlParameter = New SqlParameter("@CantidadAlmacen", SqlDbType.Float, 8)
            Dim _IvaAlmacen As SqlParameter = New SqlParameter("@IvaAlmacen", SqlDbType.Float, 8)
            Dim _IvaPorcentaje As SqlParameter = New SqlParameter("@IvaPorcentaje", SqlDbType.Float, 8)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)

            _Factura.Value = Factura
            _Item.Value = Item
            _Cantidad.Value = Cantidad
            _Costo.Value = Costo
            _Descuento.Value = Descuento
            _Iva.Value = Iva
            _Tipo.Value = Tipo
            _CantidadAlmacen.Value = CantidadAlmacen
            _IvaAlmacen.Value = IvaAlmacen
            _IvaPorcentaje.Value = IvaPorcentaje
            _Empresa.Value = EmpresaActual
            _Proveedor.Value = Proveedor


            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Cantidad)
            cmd.Parameters.Add(_Costo)
            cmd.Parameters.Add(_Descuento)
            cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_CantidadAlmacen)
            cmd.Parameters.Add(_IvaAlmacen)
            cmd.Parameters.Add(_IvaPorcentaje)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Proveedor)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Sub

        Public Shared Sub OrdenesComprasUpdateEstado(ByVal Numero As String, ByVal Estado As String)
            Dim cmd As SqlCommand = New SqlCommand("_OrdenesComprasUpdateEstado_afijo", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Numero As SqlParameter = New SqlParameter("@Numero", SqlDbType.NVarChar)
            Dim _Estado As SqlParameter = New SqlParameter("@Estado", SqlDbType.NVarChar)
            'Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Numero.Value = Numero
            _Estado.Value = Estado
            '_Factura.Value = Factura
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Numero)
            cmd.Parameters.Add(_Estado)
            'cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Sub

        Public Shared Sub UpdateFechaAlmacen(ByVal Numero As String, ByVal Fecha As String, ByVal Proveedor As String, ByVal Bodega As String)
            Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasUpdateFechaAlmacen_afijo", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Numero As SqlParameter = New SqlParameter("@Numero", SqlDbType.NVarChar)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)
            Dim _Bodega As SqlParameter = New SqlParameter("@Bodega", SqlDbType.NVarChar)

            _Numero.Value = Numero
            _Fecha.Value = Fecha
            _Empresa.Value = EmpresaActual
            _Proveedor.Value = Proveedor
            _Bodega.Value = Bodega

            cmd.Parameters.Add(_Numero)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_Bodega)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Sub

        Public Shared Sub UpdateCantidadAlmacen(ByVal Numero As String, ByVal Item As String, ByVal Tipo As String, ByVal Cantidad As String, ByVal IvaAlmacen As String, ByVal Proveedor As String)
            Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasUpdateCantidadAlmacen_Afijo", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Numero As SqlParameter = New SqlParameter("@Numero", SqlDbType.NVarChar)
            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim _Cantidad As SqlParameter = New SqlParameter("@Cantidad", SqlDbType.Float)
            Dim _IvaAlmacen As SqlParameter = New SqlParameter("@IvaAlmacen", SqlDbType.Float)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Int, 4)

            _Numero.Value = Numero
            _Item.Value = Item
            _Tipo.Value = Tipo
            _Cantidad.Value = Cantidad
            _IvaAlmacen.Value = IvaAlmacen
            _Empresa.Value = EmpresaActual
            _Proveedor.Value = Proveedor

            cmd.Parameters.Add(_Numero)
            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Cantidad)
            cmd.Parameters.Add(_IvaAlmacen)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Proveedor)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Sub

        Public Shared Sub SumarExistencias(ByVal Item As String, ByVal Cantidad As String, ByVal Tipo As String)

            Dim cmd As SqlCommand = New SqlCommand("_ItemsSumarExistencia_Afijo", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar, 50)
            Dim _Cantidad As SqlParameter = New SqlParameter("@Cantidad", SqlDbType.NVarChar, 50)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar, 2)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Item.Value = Item
            _Cantidad.Value = Cantidad
            _Tipo.Value = Tipo
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Cantidad)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Sub

        Public Shared Sub UpdateCosto(ByVal Item As String, ByVal Costo As String, ByVal Tipo As String)

            Dim cmd As SqlCommand = New SqlCommand("_ItemsUpdateCosto_afijo", DBConnFacturas)

            cmd.CommandType = CommandType.StoredProcedure

            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim _Costo As SqlParameter = New SqlParameter("@Costo", SqlDbType.Float)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar, 2)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Item.Value = Item
            _Costo.Value = Costo
            _Tipo.Value = Tipo
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Costo)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Sub

        Public Shared Sub CancelarFactura(ByVal Factura As String, ByVal Proveedor As String, ByVal Estado As Integer)

            ' Create Instance of Connection and Command Object
            Dim conexion As New VB.SysContab.Rutinas
            Dim cmd As New SqlCommand("_FacturasComprasCancelar_afijo", DBConnFacturas)


            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _Factura As New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            _Factura.Value = Factura
            cmd.Parameters.Add(_Factura)

            Dim _Proveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar, 50)
            _Proveedor.Value = Proveedor
            cmd.Parameters.Add(_Proveedor)

            Dim _Estado As New SqlParameter("@Estado", SqlDbType.Int)
            _Estado.Value = Estado
            cmd.Parameters.Add(_Estado)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Sub

        Public Shared Function EntradaAlmacenDetalle(ByVal Factura As String, ByVal Proveedor As String, ByVal Destino As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EntradaAlmacenDetalle_afijo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pDestino As New SqlParameter("@Destino", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pProveedor.Value = Proveedor
            pDestino.Value = Destino
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pDestino)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Compras")

            DBConn.Close()

            Return dsFicha

        End Function
    End Class

    Public Class Activo_Fijo_BajaDB
        Public Sub AddItem(ByVal Codigo As String, ByVal Fecha_Baja As Date, ByVal Empleado As String, _
            ByVal Motivo As String, ByVal Fecha_Perdida As String, ByVal Documentos As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            DBCommand = New SqlDataAdapter("_Activo_Fijo_BajaAdd", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo_Activo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha_Baja", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Emp_codigo", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@motivo_baja", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Fecha_Perdida", SqlDbType.SmallDateTime)
            Dim pIdent7 As New SqlParameter("@Doc_relacionados", SqlDbType.Text)


            pIdent1.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Fecha_Baja
            pIdent4.Value = Empleado
            pIdent5.Value = Motivo
            pIdent6.Value = Fecha_Perdida
            pIdent7.Value = Documentos

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Public Sub UpdateItem(ByVal Codigo As String, ByVal Fecha_Baja As Date, ByVal Empleado As String, _
            ByVal Motivo As String, ByVal Fecha_Perdida As String, ByVal Documentos As String)

            ' Crea una instancia de conexion y un comando SQL

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            DBCommand = New SqlDataAdapter("_Activo_Fijo_BajaUpdate", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo_Activo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha_Baja", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Emp_codigo", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@motivo_baja", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Fecha_Perdida", SqlDbType.SmallDateTime)
            Dim pIdent7 As New SqlParameter("@Doc_relacionados", SqlDbType.Text)


            pIdent1.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Fecha_Baja
            pIdent4.Value = Empleado
            pIdent5.Value = Motivo
            pIdent6.Value = Fecha_Perdida
            pIdent7.Value = Documentos

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Public Sub DeleteItem(ByVal Codigo As String)
            ' Crea una instancia de conexion y un comando SQL
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            DBCommand = New SqlDataAdapter("_Activo_Fijo_BajaDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo_Activo", SqlDbType.NVarChar)


            pIdent1.Value = EmpresaActual
            pIdent2.Value = Codigo

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Function GetList(ByVal Filtro As String) As DataSet
            ' Crea una instancia de conexion y un comando SQL

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            DBCommand = New SqlDataAdapter("_GetListActivo_Fijo_Baja", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Filtro", SqlDbType.NVarChar)


            pIdent1.Value = EmpresaActual
            pIdent2.Value = Filtro

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            Try
                DBCommand.Fill(dsFicha, "Activo_Fijos_Baja")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DBConn.Close()
            Return dsFicha

        End Function
    End Class


    Public Class Activo_FijosDB

        Public Shared Sub Contabilizar(ByVal Codigo As String)

            ' Create Instance of Connection and Command Object
            'Dim conexion As New VB.SysContab.Rutinas()
            Dim cmd As New SqlCommand("_ActivoFijoContabilizar", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _TipoComp As New SqlParameter("@Codigo", SqlDbType.NVarChar, 6)
            _TipoComp.Value = Codigo
            cmd.Parameters.Add(_TipoComp)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()


        End Sub

        Public Function GetListContabilizar(ByVal mes As String) As DataSet

            ' Crea una instancia de conexion y un comando SQL

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            DBCommand = New SqlDataAdapter("_GetList_Depreciacion_Comprobante", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@mes", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = mes

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Try
                DBCommand.Fill(dsFicha, "Tabla")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DBConn.Close()
            Return dsFicha

        End Function


        Public Function GetList_Meses(ByVal Filtro As Boolean) As DataSet

            ' Crea una instancia de conexion y un comando SQL

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            DBCommand = New SqlDataAdapter("_GetList_MesesDepreciacion", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Contabilizado", SqlDbType.Bit)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = Filtro

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Try
                DBCommand.Fill(dsFicha, "Meses")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DBConn.Close()
            Return dsFicha

        End Function


        Public Function GeneradorReportes(ByVal Empleado As String, ByVal Departamento As String, ByVal Cargo As String, ByVal Estado As String, ByVal Situacion As String, ByVal Orden As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GeneradorReportesActivos", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpleado As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pDepartamento As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pCargo As New SqlParameter("@Cargo", SqlDbType.NVarChar)
            Dim pEstatus As New SqlParameter("@Estatus", SqlDbType.Int)
            Dim pOrden As New SqlParameter("@Orden", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pSituacion As New SqlParameter("@Situacion", SqlDbType.Int)

            pEmpleado.Value = Empleado
            pDepartamento.Value = Departamento
            pCargo.Value = Cargo
            pEstatus.Value = Estado
            pOrden.Value = Orden
            pEmpresa.Value = EmpresaActual
            pSituacion.Value = Situacion

            DBCommand.SelectCommand.Parameters.Add(pEmpleado)
            DBCommand.SelectCommand.Parameters.Add(pDepartamento)
            DBCommand.SelectCommand.Parameters.Add(pCargo)
            DBCommand.SelectCommand.Parameters.Add(pEstatus)
            DBCommand.SelectCommand.Parameters.Add(pOrden)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pSituacion)
            Try
                DBCommand.Fill(dsFicha, "Activo_Fijos")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            DBConn.Close()


            Return dsFicha
        End Function

        Public Function GetListReporte(ByVal Empleado As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListActivosEmpleadoReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Empleado
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "EMPLEADOS")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GetDetails(ByVal Codigo As String) As Activo_FijosDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsActivo_Fijos As New DataSet
            Dim Details As New Activo_FijosDetails

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListActivoDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.NVarChar)
            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)


            DBCommand.Fill(dsActivo_Fijos, "Activo_Fijos")

            DBConn.Close()


            If dsActivo_Fijos.Tables("Activo_Fijos").Rows.Count = 1 Then
                Details.Codigo = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("Codigo_Activo").ToString
                Details.Descripcion = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("DESCRIPCION").ToString
                Details.Precio = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("PRECIO").ToString
                Details.Valor_Libros = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("valor_libros").ToString
                Details.Grupo_Depreciacion = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("GRUPO_DEPRECIACION").ToString
                Details.Cuenta_Depreciacion = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("CUENTA_DEPRECIACION").ToString
                Details.Cuenta_Gastos = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("CUENTA_GASTOS").ToString
                Details.Empleado = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("codigo_empleado").ToString
                Details.Fecha_Entrada = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("Fecha_Entrada")
                Details.Estado = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("estado").ToString
                Details.Tipo = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("Tipo")
                Details.Comentarios = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("Comentarios")
                Details.Factura = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("Factura")
                Details.Proveedor = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("Proveedor")

                If Details.Tipo = "P" Then 'Propiedad
                    Details.ArticuloDetail = Nothing
                    Details.VehiculoDetail = Nothing
                    Details.PropiedadDetail.Registro_Catastral = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("registro_Catastral").ToString
                    Details.PropiedadDetail.Escritura = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("escritura").ToString
                    Details.PropiedadDetail.Fecha_Escritura = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("fecha_escritura").ToString
                    Details.PropiedadDetail.Registro = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("registro").ToString
                    Details.PropiedadDetail.Tomo = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("tomo").ToString
                    Details.PropiedadDetail.Folio = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("folio").ToString
                ElseIf Details.Tipo = "A" Then 'Articulo
                    Details.PropiedadDetail = Nothing
                    Details.VehiculoDetail = Nothing
                    Details.ArticuloDetail.Unidad = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("UNIDAD").ToString
                    Details.ArticuloDetail.Codigo_Barra = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("CODIGO_BARRA").ToString
                ElseIf Details.Tipo = "V" Then
                    Details.PropiedadDetail = Nothing
                    Details.ArticuloDetail = Nothing
                    Details.VehiculoDetail.Año = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("Año")
                    Details.VehiculoDetail.Chasis = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("Chasis")
                    Details.VehiculoDetail.Color = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("Color")
                    Details.VehiculoDetail.Marca = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("Marca")
                    Details.VehiculoDetail.Modelo = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("Modelo")
                    Details.VehiculoDetail.Motor = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("Motor")
                    Details.VehiculoDetail.Placa = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("Placa")
                    Details.VehiculoDetail.TipoAuto = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("TipoAuto")
                End If
            End If

            Return Details

        End Function

        Public Function GetList(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT Codigo_Activo as [CODIGO ], DESCRIPCION FROM Activo_Fijos WHERE Empresa = '" & EmpresaActual & "' AND ESTADO = 'P'", DBConn)
            DBCommand = New SqlDataAdapter("_GetListActivos", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pident1 As New SqlParameter("@Filtro", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pident1.Value = Filtro
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pident1)

            DBCommand.Fill(dsFicha, "Activo_Fijos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim dsFicha As New DataSet


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT Codigo_Activo as [CODIGO ], DESCRIPCION FROM Activo_Fijos WHERE Descripcion Like '%" & Filtro & "%' And Empresa = '" & EmpresaActual & "' AND ESTADO = 'P'", DBConn)
            DBCommand = New SqlDataAdapter("_GetListActivoBuscar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Activo_Fijos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListActivoEmpleado(ByVal Codigo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListActivoEmpleado", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Activo_Fijos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListCodigo(ByVal Codigo As String) As DataSet  'ByVal Filtro As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("Select CodGrup as [Código], Nombre, Nivel, Total From GRUPOS WHERE Tipo = '" & Tipo & "' AND CodGrup ='" & Filtro & "' AND Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand = New SqlDataAdapter("_GetListActivoCodigo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Activos_Fijos")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Sub Delete(ByVal Codigo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            DBCommand = New SqlDataAdapter("_ActivoFijoDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                cmd.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub


        Public Function Calc_Depreciacion(ByVal Fecha As Date) As Integer

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            DBCommand = New SqlDataAdapter("_Activo_Fijo_Calcular_Depreciacion ", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim pIdent3 As New SqlParameter("@Estado", SqlDbType.Int)
            pIdent3.Direction = ParameterDirection.Output


            pIdent1.Value = EmpresaActual
            pIdent2.Value = Fecha
            pIdent3.Value = 0

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
                Return pIdent3.Value
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Sub AddItem_Articulo(ByVal Codigo As String, ByVal Descripcion As String, _
          ByVal Precio As String, ByVal Grupo_Depreciacion As String, ByVal Cuenta_Gastos As String, _
          ByVal Cuenta_Depreciacion As String, ByVal Fecha_Entrada As Date, ByVal Codigo_barra As String, ByVal Unidad As String, _
          ByVal Estado As String, ByVal Situacion As String, ByVal Tipo As String, ByVal Factura As String, ByVal Proveedor As String, ByVal lComentarios As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            DBCommand = New SqlDataAdapter("_ActivoFijoAdd_Articulo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha_Entrada", SqlDbType.DateTime)
            Dim pIdent4 As New SqlParameter("@Precio", SqlDbType.Float)
            Dim pIdent5 As New SqlParameter("@Grupo_Depreciacion", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Codigo_Empleado", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Cuenta_Gastos", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@Cuenta_Depreciacion", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@Situacion", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent13 As New SqlParameter("@Codigo_barra", SqlDbType.NVarChar)
            Dim pIdent14 As New SqlParameter("@Unidad", SqlDbType.NVarChar)
            Dim pIdent15 As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pIdent16 As New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim pIdent17 As New SqlParameter("@Comentarios", SqlDbType.NVarChar)


            pIdent1.Value = Codigo
            pIdent2.Value = Descripcion
            pIdent3.Value = IIf(IsDBNull(Fecha_Entrada), Today, Fecha_Entrada)
            pIdent4.Value = Precio
            pIdent5.Value = Grupo_Depreciacion
            pIdent6.Value = ""
            pIdent7.Value = Cuenta_Gastos
            pIdent8.Value = Cuenta_Depreciacion
            pIdent9.Value = Estado
            pIdent10.Value = Situacion
            pIdent11.Value = Tipo
            pIdent12.Value = EmpresaActual
            pIdent13.Value = Codigo_barra
            pIdent14.Value = Unidad
            pIdent15.Value = Factura
            pIdent16.Value = Proveedor
            pIdent17.Value = lComentarios

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent10)
            DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)
            DBCommand.SelectCommand.Parameters.Add(pIdent13)
            DBCommand.SelectCommand.Parameters.Add(pIdent14)
            DBCommand.SelectCommand.Parameters.Add(pIdent15)
            DBCommand.SelectCommand.Parameters.Add(pIdent16)
            DBCommand.SelectCommand.Parameters.Add(pIdent17)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub AddItem_Propiedad(ByVal Codigo As String, ByVal Descripcion As String, _
          ByVal Precio As String, ByVal Grupo_Depreciacion As String, _
          ByVal Cuenta_Gastos As String, ByVal Cuenta_Depreciacion As String, ByVal Fecha_Entrada As Date, _
          ByVal Registro_Catastral As String, ByVal Escritura As String, ByVal Fecha_escritura As String, _
          ByVal lRegistro As String, ByVal Tomo As String, ByVal Folio As String, _
          ByVal Estado As String, ByVal Situacion As String, ByVal Tipo As String, ByVal lComentarios As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            DBCommand = New SqlDataAdapter("_ActivoFijoAdd_Propiedad", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha_Entrada", SqlDbType.DateTime)
            Dim pIdent4 As New SqlParameter("@Precio", SqlDbType.Float)
            Dim pIdent5 As New SqlParameter("@Grupo_Depreciacion", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Codigo_Empleado", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Cuenta_Gastos", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@Cuenta_Depreciacion", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@Situacion", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent13 As New SqlParameter("@Registro_Catastral", SqlDbType.NVarChar)
            Dim pIdent14 As New SqlParameter("@Escritura", SqlDbType.NVarChar)
            Dim pIdent15 As New SqlParameter("@Fecha_Escritura", SqlDbType.NVarChar)
            Dim pIdent16 As New SqlParameter("@Registro", SqlDbType.NVarChar)
            Dim pIdent17 As New SqlParameter("@Tomo", SqlDbType.NVarChar)
            Dim pIdent18 As New SqlParameter("@Folio", SqlDbType.NVarChar)
            Dim pIdent19 As New SqlParameter("@Comentarios", SqlDbType.NVarChar)


            pIdent1.Value = Codigo
            pIdent2.Value = Descripcion
            pIdent3.Value = IIf(IsDBNull(Fecha_Entrada), Today, Fecha_Entrada)
            pIdent4.Value = Precio
            pIdent5.Value = Grupo_Depreciacion
            pIdent6.Value = ""
            pIdent7.Value = Cuenta_Gastos
            pIdent8.Value = Cuenta_Depreciacion
            pIdent9.Value = Estado
            pIdent10.Value = Situacion
            pIdent11.Value = Tipo
            pIdent12.Value = EmpresaActual
            pIdent13.Value = Registro_Catastral
            pIdent14.Value = Escritura
            pIdent15.Value = Fecha_escritura
            pIdent16.Value = Registro
            pIdent17.Value = Tomo
            pIdent18.Value = Folio
            pIdent19.Value = lComentarios

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent10)
            DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)
            DBCommand.SelectCommand.Parameters.Add(pIdent13)
            DBCommand.SelectCommand.Parameters.Add(pIdent14)
            DBCommand.SelectCommand.Parameters.Add(pIdent15)
            DBCommand.SelectCommand.Parameters.Add(pIdent16)
            DBCommand.SelectCommand.Parameters.Add(pIdent17)
            DBCommand.SelectCommand.Parameters.Add(pIdent18)
            DBCommand.SelectCommand.Parameters.Add(pIdent19)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub AddItem_Vehiculo(ByVal Codigo As String, ByVal Descripcion As String, _
          ByVal Precio As String, ByVal Grupo_Depreciacion As String, _
          ByVal Cuenta_Gastos As String, ByVal Cuenta_Depreciacion As String, ByVal Fecha_Entrada As Date, _
          ByVal Estado As String, ByVal Situacion As String, ByVal Tipo As String, ByVal Motor As String, _
          ByVal Chasis As String, ByVal Marca As String, ByVal Modelo As String, ByVal TipoAuto As String, _
          ByVal Color As String, ByVal Placa As String, ByVal Año As String, ByVal Factura As String, _
          ByVal Proveedor As String, ByVal lComentarios As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            DBCommand = New SqlDataAdapter("_ActivoFijoAdd_Vehiculo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha_Entrada", SqlDbType.DateTime)
            Dim pIdent4 As New SqlParameter("@Precio", SqlDbType.Float)
            Dim pIdent5 As New SqlParameter("@Grupo_Depreciacion", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Codigo_Empleado", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Cuenta_Gastos", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@Cuenta_Depreciacion", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@Situacion", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent13 As New SqlParameter("@Motor", SqlDbType.NVarChar)
            Dim pIdent14 As New SqlParameter("@Chasis", SqlDbType.NVarChar)
            Dim pIdent15 As New SqlParameter("@Marca", SqlDbType.NVarChar)
            Dim pIdent16 As New SqlParameter("@Modelo", SqlDbType.NVarChar)
            Dim pIdent17 As New SqlParameter("@TipoAuto", SqlDbType.NVarChar)
            Dim pIdent18 As New SqlParameter("@Color", SqlDbType.NVarChar)
            Dim pIdent19 As New SqlParameter("@Placa", SqlDbType.NVarChar)
            Dim pIdent20 As New SqlParameter("@Año", SqlDbType.NVarChar)
            Dim pIdent21 As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pIdent22 As New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim pIdent23 As New SqlParameter("@Comentarios", SqlDbType.NVarChar)

            pIdent1.Value = Codigo
            pIdent2.Value = Descripcion
            pIdent3.Value = IIf(IsDBNull(Fecha_Entrada), Today, Fecha_Entrada)
            pIdent4.Value = Precio
            pIdent5.Value = Grupo_Depreciacion
            pIdent6.Value = ""
            pIdent7.Value = Cuenta_Gastos
            pIdent8.Value = Cuenta_Depreciacion
            pIdent9.Value = Estado
            pIdent10.Value = Situacion
            pIdent11.Value = Tipo
            pIdent12.Value = EmpresaActual
            pIdent13.Value = Motor
            pIdent14.Value = Chasis
            pIdent15.Value = Marca
            pIdent16.Value = Modelo
            pIdent17.Value = TipoAuto
            pIdent18.Value = Color
            pIdent19.Value = Placa
            pIdent20.Value = Año
            pIdent21.Value = Factura
            pIdent22.Value = Proveedor
            pIdent23.Value = lComentarios

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent10)
            DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)
            DBCommand.SelectCommand.Parameters.Add(pIdent13)
            DBCommand.SelectCommand.Parameters.Add(pIdent14)
            DBCommand.SelectCommand.Parameters.Add(pIdent15)
            DBCommand.SelectCommand.Parameters.Add(pIdent16)
            DBCommand.SelectCommand.Parameters.Add(pIdent17)
            DBCommand.SelectCommand.Parameters.Add(pIdent18)
            DBCommand.SelectCommand.Parameters.Add(pIdent19)
            DBCommand.SelectCommand.Parameters.Add(pIdent20)
            DBCommand.SelectCommand.Parameters.Add(pIdent21)
            DBCommand.SelectCommand.Parameters.Add(pIdent22)
            DBCommand.SelectCommand.Parameters.Add(pIdent23)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        'Public Function Update(ByVal Codigo As String, ByVal Descripcion As String, ByVal Codigo_Barra As String, _
        '    ByVal Unidad As String, ByVal Fecha_Entrada As String, ByVal Precio As String, ByVal Grupo_Depreciacion As String, _
        '    ByVal Cuenta_Gastos As String, ByVal Cuenta_Depreciacion As String, _
        '  ByVal Registro_Catastral As String, ByVal Escritura As String, ByVal Fecha_escritura As String, _
        '  ByVal Registro As String, ByVal Tomo As String, ByVal Folio As String)
        '    ', ByVal Estado As String)

        '    ' Crea una instancia de conexion y un comando SQL
        '    Dim cmd As New SqlCommand()
        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter


        '    Dim conexion As New VB.SysContab.Rutinas()
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion)

        '    ' Se define el tipo de comando
        '    DBCommand = New SqlDataAdapter("_ActivoFijoUpdate", DBConn)
        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
        '    Dim pIdent2 As New SqlParameter("@Descripcion", SqlDbType.NVarChar)
        '    Dim pIdent3 As New SqlParameter("@Codigo_barra", SqlDbType.NVarChar)
        '    Dim pIdent4 As New SqlParameter("@Unidad", SqlDbType.NVarChar)
        '    Dim pIdent5 As New SqlParameter("@Fecha_Entrada", SqlDbType.DateTime)
        '    Dim pIdent6 As New SqlParameter("@Precio", SqlDbType.Float)
        '    Dim pIdent7 As New SqlParameter("@Grupo_Depreciacion", SqlDbType.NVarChar)
        '    ''Dim pIdent8 As New SqlParameter("@Codigo_Empleado", SqlDbType.NVarChar)
        '    Dim pIdent9 As New SqlParameter("@Cuenta_Gastos", SqlDbType.NVarChar)
        '    Dim pIdent10 As New SqlParameter("@Cuenta_Depreciacion", SqlDbType.NVarChar)
        '    ''Dim pIdent11 As New SqlParameter("@Estado", SqlDbType.NVarChar)
        '    Dim pIdent12 As New SqlParameter("@Empresa", SqlDbType.Int)
        '    Dim pIdent13 As New SqlParameter("@Registro_Catastral", SqlDbType.NVarChar)
        '    Dim pIdent14 As New SqlParameter("@Escritura", SqlDbType.NVarChar)
        '    Dim pIdent15 As New SqlParameter("@Fecha_Escritura", SqlDbType.NVarChar)
        '    Dim pIdent16 As New SqlParameter("@Registro", SqlDbType.NVarChar)
        '    Dim pIdent17 As New SqlParameter("@Tomo", SqlDbType.NVarChar)
        '    Dim pIdent18 As New SqlParameter("@Folio", SqlDbType.NVarChar)


        '    pIdent.Value = Codigo
        '    pIdent2.Value = Descripcion
        '    pIdent3.Value = IIf(IsDBNull(Codigo_Barra), "", Fecha_Entrada)
        '    pIdent4.Value = Unidad
        '    pIdent5.Value = IIf(IsDBNull(Fecha_Entrada), Today, Fecha_Entrada)
        '    pIdent6.Value = Precio
        '    pIdent7.Value = Grupo_Depreciacion
        '    ''pIdent8.Value = DBNull.Value
        '    pIdent9.Value = Cuenta_Gastos
        '    pIdent10.Value = Cuenta_Depreciacion
        '    ''pIdent11.Value = Estado
        '    pIdent12.Value = EmpresaActual
        '    pIdent13.Value = Registro_Catastral
        '    pIdent14.Value = Escritura
        '    pIdent15.Value = Fecha_escritura
        '    pIdent16.Value = Registro
        '    pIdent17.Value = Tomo
        '    pIdent18.Value = Folio

        '    DBCommand.SelectCommand.Parameters.Add(pIdent)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent2)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent3)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent4)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent5)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent6)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent7)
        '    ''DBCommand.SelectCommand.Parameters.Add(pIdent8)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent9)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent10)
        '    ''DBCommand.SelectCommand.Parameters.Add(pIdent11)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent12)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent13)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent14)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent15)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent16)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent17)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent18)


        '    Try
        '        'Se asigna conexion al comando y se abre conexion 
        '        DBConn.Open()
        '        DBCommand.SelectCommand.ExecuteNonQuery()
        '        DBConn.Close()
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try

        'End Function

        Public Sub AsignarActivo(ByVal Empleado As String, ByVal Codigo As String)


            ' cmd.CommandText = "UPDATE Activo_Fijos SET CODIGO_EMPLEADO = '" & Empleado & "', ESTADO = 'A' WHERE CODIGO_ACTIVO = '" & Codigo & "' AND Empresa = '" & EmpresaActual & "'"


            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_AsignarActivoFijo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pident2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pident2.Value = Empleado
            pIdent3.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pident2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End Sub

        Public Sub TrasladarActivo(ByVal EmpleadoAnterior As String, ByVal EmpleadoNuevo As String, ByVal Codigo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE Activo_Fijos SET CODIGO_EMPLEADO = '" & EmpleadoNuevo & "', ESTADO = 'A' WHERE CODIGO_ACTIVO = '" & Codigo & "' AND CODIGO_EMPLEADO ='" & EmpleadoAnterior & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Sub

        Public Sub UpdateItem_Articulo(ByVal Codigo As String, ByVal Descripcion As String, _
          ByVal Precio As String, ByVal Grupo_Depreciacion As String, ByVal Cuenta_Gastos As String, _
          ByVal Cuenta_Depreciacion As String, ByVal Fecha_Entrada As Date, ByVal Codigo_barra As String, _
          ByVal Unidad As String, ByVal Estado As String, ByVal Situacion As String, ByVal Tipo As String, _
          ByVal Factura As String, ByVal Proveedor As String, ByVal lComentarios As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            DBCommand = New SqlDataAdapter("_ActivoFijoUpdate_Articulo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha_Entrada", SqlDbType.DateTime)
            Dim pIdent4 As New SqlParameter("@Precio", SqlDbType.Float)
            Dim pIdent5 As New SqlParameter("@Grupo_Depreciacion", SqlDbType.NVarChar)
            'Dim pIdent6 As New SqlParameter("@Codigo_Empleado", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Cuenta_Gastos", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@Cuenta_Depreciacion", SqlDbType.NVarChar)
            'Dim pIdent9 As New SqlParameter("@Estado", SqlDbType.NVarChar)
            'Dim pIdent10 As New SqlParameter("@Situacion", SqlDbType.NVarChar)
            'Dim pIdent11 As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent13 As New SqlParameter("@Codigo_barra", SqlDbType.NVarChar)
            Dim pIdent14 As New SqlParameter("@Unidad", SqlDbType.NVarChar)
            Dim pIdent15 As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pIdent16 As New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim pIdent17 As New SqlParameter("@Comentarios", SqlDbType.NVarChar)


            pIdent1.Value = Codigo
            pIdent2.Value = Descripcion
            pIdent3.Value = IIf(IsDBNull(Fecha_Entrada), Today, Fecha_Entrada)
            pIdent4.Value = Precio
            pIdent5.Value = Grupo_Depreciacion
            'pIdent6.Value = ""
            pIdent7.Value = Cuenta_Gastos
            pIdent8.Value = Cuenta_Depreciacion
            'pIdent9.Value = Estado
            'pIdent10.Value = Situacion
            'pIdent11.Value = Tipo
            pIdent12.Value = EmpresaActual
            pIdent13.Value = Codigo_barra
            pIdent14.Value = Unidad
            pIdent15.Value = Factura
            pIdent16.Value = Proveedor
            pIdent17.Value = lComentarios

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            'DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            'DBCommand.SelectCommand.Parameters.Add(pIdent9)
            'DBCommand.SelectCommand.Parameters.Add(pIdent10)
            'DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)
            DBCommand.SelectCommand.Parameters.Add(pIdent13)
            DBCommand.SelectCommand.Parameters.Add(pIdent14)
            DBCommand.SelectCommand.Parameters.Add(pIdent15)
            DBCommand.SelectCommand.Parameters.Add(pIdent16)
            DBCommand.SelectCommand.Parameters.Add(pIdent17)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub UpdateItem_Propiedad(ByVal Codigo As String, ByVal Descripcion As String, _
          ByVal Precio As String, ByVal Grupo_Depreciacion As String, _
          ByVal Cuenta_Gastos As String, ByVal Cuenta_Depreciacion As String, ByVal Fecha_Entrada As Date, _
          ByVal Registro_Catastral As String, ByVal Escritura As String, ByVal Fecha_escritura As String, _
          ByVal lRegistro As String, ByVal Tomo As String, ByVal Folio As String, _
          ByVal Estado As String, ByVal Situacion As String, ByVal Tipo As String, _
          ByVal lComentarios As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            DBCommand = New SqlDataAdapter("_ActivoFijoUpdate_Propiedad", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha_Entrada", SqlDbType.DateTime)
            Dim pIdent4 As New SqlParameter("@Precio", SqlDbType.Float)
            Dim pIdent5 As New SqlParameter("@Grupo_Depreciacion", SqlDbType.NVarChar)
            'Dim pIdent6 As New SqlParameter("@Codigo_Empleado", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Cuenta_Gastos", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@Cuenta_Depreciacion", SqlDbType.NVarChar)
            'Dim pIdent9 As New SqlParameter("@Estado", SqlDbType.NVarChar)
            'Dim pIdent10 As New SqlParameter("@Situacion", SqlDbType.NVarChar)
            'Dim pIdent11 As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent13 As New SqlParameter("@Registro_Catastral", SqlDbType.NVarChar)
            Dim pIdent14 As New SqlParameter("@Escritura", SqlDbType.NVarChar)
            Dim pIdent15 As New SqlParameter("@Fecha_Escritura", SqlDbType.NVarChar)
            Dim pIdent16 As New SqlParameter("@Registro", SqlDbType.NVarChar)
            Dim pIdent17 As New SqlParameter("@Tomo", SqlDbType.NVarChar)
            Dim pIdent18 As New SqlParameter("@Folio", SqlDbType.NVarChar)
            Dim pIdent19 As New SqlParameter("@Comentarios", SqlDbType.NVarChar)


            pIdent1.Value = Codigo
            pIdent2.Value = Descripcion
            pIdent3.Value = IIf(IsDBNull(Fecha_Entrada), Today, Fecha_Entrada)
            pIdent4.Value = Precio
            pIdent5.Value = Grupo_Depreciacion
            'pIdent6.Value = ""
            pIdent7.Value = Cuenta_Gastos
            pIdent8.Value = Cuenta_Depreciacion
            'pIdent9.Value = Estado
            'pIdent10.Value = Situacion
            'pIdent11.Value = Tipo
            pIdent12.Value = EmpresaActual
            pIdent13.Value = Registro_Catastral
            pIdent14.Value = Escritura
            pIdent15.Value = Fecha_escritura
            pIdent16.Value = Registro
            pIdent17.Value = Tomo
            pIdent18.Value = Folio
            pIdent19.Value = lComentarios

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            'DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            'DBCommand.SelectCommand.Parameters.Add(pIdent9)
            'DBCommand.SelectCommand.Parameters.Add(pIdent10)
            'DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)
            DBCommand.SelectCommand.Parameters.Add(pIdent13)
            DBCommand.SelectCommand.Parameters.Add(pIdent14)
            DBCommand.SelectCommand.Parameters.Add(pIdent15)
            DBCommand.SelectCommand.Parameters.Add(pIdent16)
            DBCommand.SelectCommand.Parameters.Add(pIdent17)
            DBCommand.SelectCommand.Parameters.Add(pIdent18)
            DBCommand.SelectCommand.Parameters.Add(pIdent19)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub UpdateItem_Vehiculo(ByVal Codigo As String, ByVal Descripcion As String, _
          ByVal Precio As String, ByVal Grupo_Depreciacion As String, _
          ByVal Cuenta_Gastos As String, ByVal Cuenta_Depreciacion As String, ByVal Fecha_Entrada As Date, _
          ByVal Estado As String, ByVal Situacion As String, ByVal Tipo As String, ByVal Motor As String, _
          ByVal Chasis As String, ByVal Marca As String, ByVal Modelo As String, ByVal TipoAuto As String, _
          ByVal Color As String, ByVal Placa As String, ByVal Año As String, ByVal Factura As String, _
          ByVal Proveedor As String, ByVal lComentarios As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            DBCommand = New SqlDataAdapter("_ActivoFijoUpdate_Vehiculo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha_Entrada", SqlDbType.DateTime)
            Dim pIdent4 As New SqlParameter("@Precio", SqlDbType.Float)
            Dim pIdent5 As New SqlParameter("@Grupo_Depreciacion", SqlDbType.NVarChar)
            'Dim pIdent6 As New SqlParameter("@Codigo_Empleado", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Cuenta_Gastos", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@Cuenta_Depreciacion", SqlDbType.NVarChar)
            'Dim pIdent9 As New SqlParameter("@Estado", SqlDbType.NVarChar)
            'Dim pIdent10 As New SqlParameter("@Situacion", SqlDbType.NVarChar)
            'Dim pIdent11 As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent13 As New SqlParameter("@Motor", SqlDbType.NVarChar)
            Dim pIdent14 As New SqlParameter("@Chasis", SqlDbType.NVarChar)
            Dim pIdent15 As New SqlParameter("@Marca", SqlDbType.NVarChar)
            Dim pIdent16 As New SqlParameter("@Modelo", SqlDbType.NVarChar)
            Dim pIdent17 As New SqlParameter("@TipoAuto", SqlDbType.NVarChar)
            Dim pIdent18 As New SqlParameter("@Color", SqlDbType.NVarChar)
            Dim pIdent19 As New SqlParameter("@Placa", SqlDbType.NVarChar)
            Dim pIdent20 As New SqlParameter("@Año", SqlDbType.NVarChar)
            Dim pIdent21 As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pIdent22 As New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim pIdent23 As New SqlParameter("@Comentarios", SqlDbType.NVarChar)

            pIdent1.Value = Codigo
            pIdent2.Value = Descripcion
            pIdent3.Value = IIf(IsDBNull(Fecha_Entrada), Today, Fecha_Entrada)
            pIdent4.Value = Precio
            pIdent5.Value = Grupo_Depreciacion
            'pIdent6.Value = ""
            pIdent7.Value = Cuenta_Gastos
            pIdent8.Value = Cuenta_Depreciacion
            'pIdent9.Value = Estado
            'pIdent10.Value = Situacion
            'pIdent11.Value = Tipo
            pIdent12.Value = EmpresaActual
            pIdent13.Value = Motor
            pIdent14.Value = Chasis
            pIdent15.Value = Marca
            pIdent16.Value = Modelo
            pIdent17.Value = TipoAuto
            pIdent18.Value = Color
            pIdent19.Value = Placa
            pIdent20.Value = Año
            pIdent21.Value = Factura
            pIdent22.Value = Proveedor
            pIdent23.Value = lComentarios

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            'DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            'DBCommand.SelectCommand.Parameters.Add(pIdent9)
            'DBCommand.SelectCommand.Parameters.Add(pIdent10)
            'DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)
            DBCommand.SelectCommand.Parameters.Add(pIdent13)
            DBCommand.SelectCommand.Parameters.Add(pIdent14)
            DBCommand.SelectCommand.Parameters.Add(pIdent15)
            DBCommand.SelectCommand.Parameters.Add(pIdent16)
            DBCommand.SelectCommand.Parameters.Add(pIdent17)
            DBCommand.SelectCommand.Parameters.Add(pIdent18)
            DBCommand.SelectCommand.Parameters.Add(pIdent19)
            DBCommand.SelectCommand.Parameters.Add(pIdent20)
            DBCommand.SelectCommand.Parameters.Add(pIdent21)
            DBCommand.SelectCommand.Parameters.Add(pIdent22)
            DBCommand.SelectCommand.Parameters.Add(pIdent23)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Function Depreciacion_Imprimir(ByVal Desde As Date, ByVal Hasta As Date) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            DBCommand = New SqlDataAdapter("_Activo_Fijo_Reporte_Depreciacion", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent3 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)


            pIdent1.Value = EmpresaActual
            pIdent2.Value = Desde
            pIdent3.Value = Hasta

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            Try
                DBCommand.Fill(dsFicha, "Depreciacion_Imprimir")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DBConn.Close()
            Return dsFicha
        End Function


    End Class

End Namespace
