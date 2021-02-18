Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class ArticulosDetails
        Public Codigo As String
        Public Nombre As String
        Public Codigo_Parte As String
        Public Nombre_Proveedor As String
        Public Proveedor As String
        Public Linea As String
        Public Grupo As String
        Public SubGrupo As String
        Public S_SubGrupo As String
        Public Modelo As String
        Public Unidad As String
        Public Presentacion As String
        Public Ubicacion As String
        Public Precio_Venta_Cordobas As Double
        Public Precio_Venta_Dolar As String
        Public Costo As Double
        Public Margen As Double
        Public Costo_Prom As Double
        Public Costo_Ultimo As Double
        Public Existencia As String
        Public Stock_Min As String
        Public Stock_Max As String
        Public Descuento_A As String
        Public Descuento_B As String
        Public Descuento_C As String
        Public Descuento_Maximo As String
        Public Tasa_Cambio As String
        Public Tipo As String
        Public Exento As Boolean
        Public Cuenta As String
        Public Concentracion As String
        Public via_administracion As String
        Public nivel_uso As String
        Public receta As String
        Public Moneda As String
        Public SKU As String
        Public Cultivo As String
        Public CCosto As String
        Public CIngreso As String
        Public Factor As Double
        Public CDevolucion As String
        Public CRebaja As String
        Public CentroCosto As String
        Public SAC As String
        Public Activo As Boolean
        Public Validar_Precio As Boolean
        Public Obsoleto As Boolean

        Public Precio_Venta2 As Double
        Public Costo2 As Double
        Public IdProyecto As Integer
        Public IdFabricante As Integer
        Public FactorIngreso As Double
        Public Marca As String
        Public Url As String
        Public Foto As Byte()
        Public Cabys As String
        Public Impuesto As Double

        'Public Nombre_Linea As String
        'Public Nombre_Grupo As ADDString
        'Public Nombre_SubGrupo As String
        'Public Nombre_Proveedor As String
    End Class

    Public Class ArticulosDB
        '

        Public Function SalidaCC() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_SalidaCC", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            DBCommand.Fill(dsFicha, "Articulos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ArticulosListLineas() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosListLineas", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.Fill(dsFicha, "Grupos_Inventario")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ItemTemporalXProveedores(ByVal Proveedor As String, ByVal Punto_Venta As String) As DataSet
            'Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ItemTemporalXProveedores", DBConnFacturas)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pPunto_Venta As New SqlParameter("@Punto_Venta", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pProveedor.Value = Proveedor
            pPunto_Venta.Value = Punto_Venta
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pPunto_Venta)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.SelectCommand.Connection = DBConnFacturas
            DBCommand.SelectCommand.Transaction = transaccionFacturas

            DBCommand.Fill(dsFicha, "Articulos")

            'DBConn.Close()

            Return dsFicha

        End Function

        Public Function ItemTemporalProveedores(ByVal Punto_Venta As String) As DataSet
            'Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ItemTemporalProveedores", DBConnFacturas)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pPunto_Venta As New SqlParameter("@Punto_Venta", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pPunto_Venta.Value = Punto_Venta
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pPunto_Venta)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.SelectCommand.Connection = DBConnFacturas
            DBCommand.SelectCommand.Transaction = transaccionFacturas

            DBCommand.Fill(dsFicha, "Articulos")

            Return dsFicha

        End Function

        Public Function ItemTemporalDelete(ByVal Punto_Venta As String)

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_ItemTemporalDelete", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            'Dim _Codigo As SqlParameter = New SqlParameter("@Codigo", SqlDbType.NVarChar, 4)
            Dim _Punto_Venta As SqlParameter = New SqlParameter("@Punto_Venta", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            '_Codigo.Value = Codigo
            _Punto_Venta.Value = Punto_Venta
            _Empresa.Value = EmpresaActual

            'cmd.Parameters.Add(_Codigo)
            cmd.Parameters.Add(_Punto_Venta)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function ItemTemporalBuscar(ByVal Item As String, ByVal Punto_Venta As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ItemTemporalBuscar", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pItem As New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim pPunto_Venta As New SqlParameter("@Punto_Venta", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pItem.Value = Item
            pPunto_Venta.Value = Punto_Venta
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pItem)
            DBCommand.SelectCommand.Parameters.Add(pPunto_Venta)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Articulos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ItemTemporalAdd(ByVal Codigo As String, ByVal Punto_Venta As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_ItemTemporalAdd", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Codigo As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim _Punto_Venta As SqlParameter = New SqlParameter("@Punto_Venta", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Codigo.Value = Codigo
            _Punto_Venta.Value = Punto_Venta
            _Empresa.Value = EmpresaActual


            cmd.Parameters.Add(_Codigo)
            cmd.Parameters.Add(_Punto_Venta)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()

        End Function

        Public Function UpdateCostoCC(ByVal Item As String, ByVal Costo As String)

            Dim cmd As SqlCommand = New SqlCommand("_ItemsCCUpdateCosto", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim _Costo As SqlParameter = New SqlParameter("@Costo", SqlDbType.Float)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Item.Value = Item
            _Costo.Value = Costo
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Costo)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function UpdateCosto(ByVal Item As String, ByVal Costo As String, ByVal Tipo As String, ByVal Cantidad As Integer)
            ' Create Instance of Connection and Command Object

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_ItemsUpdateCosto", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim _Costo As SqlParameter = New SqlParameter("@Costo", SqlDbType.Float)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar, 2)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)
            Dim _Cantidad As SqlParameter = New SqlParameter("@Cantidad", SqlDbType.Int)

            _Item.Value = Item
            _Costo.Value = Costo
            _Tipo.Value = Tipo
            _Empresa.Value = EmpresaActual
            _Cantidad.Value = Cantidad

            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Costo)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Cantidad)

            ' Open the connection and execute the Command
            'Try
            '    DBConn.Open()
            '    cmd.ExecuteNonQuery()
            '    DBConn.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message & " RestarExistencias")
            'End Try

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function


        Public Function UpdateFechaPedido(ByVal Item As String, ByVal Fecha As String)

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_ArticulosUpdateFechaPedido", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
            'Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Item.Value = Item
            _Fecha.Value = Fecha
            '_Tipo.Value = Tipo
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Fecha)
            'cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Empresa)


            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas 'Lineas
            cmd.ExecuteNonQuery()

            'cmd.Connection = DBConn
            'DBConn.Open()
            'cmd.ExecuteNonQuery()

        End Function

        Public Function ProveedoresAdicionalesDelete(ByVal Articulo As String, ByVal Proveedor As String, ByVal Tipo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_ProveedoresAdicionalesDelete", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Articulo As SqlParameter = New SqlParameter("@Articulo", SqlDbType.NVarChar)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Real)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Articulo.Value = Articulo
            _Proveedor.Value = Proveedor
            _Tipo.Value = Tipo
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Articulo)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()

        End Function

        Public Function ProveedoresAdicionalesAddItem(ByVal Articulo As String, ByVal Proveedor As String, ByVal Tipo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_ProveedoresAdicionalesAdd", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Articulo As SqlParameter = New SqlParameter("@Articulo", SqlDbType.NVarChar)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Real)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Articulo.Value = Articulo
            _Proveedor.Value = Proveedor
            _Tipo.Value = Tipo
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Articulo)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()

        End Function

        Public Function ArticulosListAll() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosListAll", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Articulos")

            DBConn.Close()

            Return dsFicha

        End Function

        '13/01/2006
        Public Function ArticulosUltimaCompra(ByVal Item As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosUltimaCompra", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pItem As New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pItem.Value = Item
            pTipo.Value = Tipo
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pItem)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Compras_Lineas")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function ArticulosList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Articulos")

            DBConn.Close()

            Return dsFicha
        End Function


        '20/10/2005
        Public Function ArticulosUltimaVenta(ByVal Item As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosUltimaVenta", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pItem As New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pItem.Value = Item
            pTipo.Value = Tipo
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pItem)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas_Lineas")

            DBConn.Close()

            Return dsFicha
        End Function

        '19/10/2005
        Public Function ArticulosConsultaLetra(ByVal Letra As String, ByVal Codigo As String, ByVal Descripcion As String, ByVal Linea As String, ByVal Proveedor As String, ByVal Estado As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosConsultaLetra", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pLetra As New SqlParameter("@Letra", SqlDbType.NVarChar)
            Dim pCodigo As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pDescripcion As New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Dim pLinea As New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pLetra.Value = Letra
            pCodigo.Value = Codigo
            pDescripcion.Value = Descripcion
            pLinea.Value = Linea
            pProveedor.Value = Proveedor
            pEstado.Value = Estado
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pLetra)
            DBCommand.SelectCommand.Parameters.Add(pCodigo)
            DBCommand.SelectCommand.Parameters.Add(pDescripcion)
            DBCommand.SelectCommand.Parameters.Add(pLinea)
            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Articulos")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function ArticulosConsultaLetra() As DataTable

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosLista", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Articulos")

            DBConn.Close()

            Return dsFicha.Tables(0)
        End Function

        '19/10/2005
        Public Function ArticulosConsulta(ByVal Codigo As String, ByVal Descripcion As String, ByVal Linea As String, ByVal Proveedor As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosConsulta", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCodigo As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pDescripcion As New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Dim pLinea As New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pCodigo.Value = Codigo
            pDescripcion.Value = Descripcion
            pLinea.Value = Linea
            pProveedor.Value = Proveedor
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pCodigo)
            DBCommand.SelectCommand.Parameters.Add(pDescripcion)
            DBCommand.SelectCommand.Parameters.Add(pLinea)
            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Articulos")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function RestarExistencias(ByVal Item As String, ByVal Cantidad As String, ByVal Tipo As String)
            ' Create Instance of Connection and Command Object

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_ItemsRestarExistencia", DBConnFacturas)

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

            ' Open the connection and execute the Command
            'Try
            '    DBConn.Open()
            '    cmd.ExecuteNonQuery()
            '    DBConn.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message & " RestarExistencias")
            'End Try

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function SumarExistencias(ByVal Item As String, ByVal Cantidad As String, ByVal Tipo As String)
            ' Create Instance of Connection and Command Object

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_ItemsSumarExistencia", DBConnFacturas)

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

            ' Open the connection and execute the Command
            'Try
            '    DBConn.Open()
            '    cmd.ExecuteNonQuery()
            '    DBConn.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message & " RestarExistencias")
            'End Try

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function ArticulosBuscar(ByVal Filtro As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosBuscar", DBConn)

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

        '*******************************************************************************
        'Creado by Jhonny Arauz
        'Obtener Lista de Productos/Servicios para Facturas Compra
        Public Function ProductosGetLista(ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosGetList", DBConn)

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

        Public Function ProductosGetAll(ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosGetAll", DBConn)

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

        Public Function GeneradorReportes(ByVal Proveedor As String, ByVal Linea As String, ByVal Orden As String, ByVal Articulo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GeneradorReportesProductos", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim pLinea As New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim pOrden As New SqlParameter("@Orden", SqlDbType.Int)
            Dim pArticulo As New SqlParameter("@Articulo", SqlDbType.NVarChar)

            pEmpresa.Value = EmpresaActual
            pProveedor.Value = Proveedor
            pLinea.Value = Linea
            pOrden.Value = Orden
            pArticulo.Value = Articulo

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pLinea)
            DBCommand.SelectCommand.Parameters.Add(pOrden)
            DBCommand.SelectCommand.Parameters.Add(pArticulo)

            DBCommand.Fill(dsFicha, "Articulos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetAcumulados(ByVal Producto As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetAcumuladosProductos", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pItem As New SqlParameter("@Producto", SqlDbType.NVarChar)
            Dim _Tipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pItem.Value = Producto
            _Tipo.Value = Tipo
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pItem)
            DBCommand.SelectCommand.Parameters.Add(_Tipo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListArticulosReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = Empresa
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "DEPARTAMENTOS")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function GetDetails(ByVal Codigo As String, ByVal Tipo As String) As ArticulosDetails

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsGrupo As New DataSet
            'Dim Details As New ArticulosDetails

            'Dim conexion As New VB.SysContab.Rutinas
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT *,(SELECT isnull(sum(ba.existencia),0) FROM BODEGAS_ARTICULOS ba" _
            '                               + " WHERE ba.codigo_articulo = a.CODIGO_ARTICULO AND ba.empresa = a.EMPRESA) Inventario" _
            '                               + " FROM ARTICULOS a WHERE a.CODIGO_ARTICULO = '" & Codigo & "' AND a.Empresa = '" & Empresa & "' AND a.Tipo = '" & Tipo & "'", DBConn)

            'DBCommand.Fill(dsGrupo, "ARTICULOS")

            Dim Details As New ArticulosDetails
            Dim dsGrupo As New DataSet
            Dim DT_ITEM As DataTable = ObtieneDatos("JAR_GetDetalleProducto2",
                                                    Codigo,
                                                    Tipo,
                                                    EmpresaActual)
            DT_ITEM.TableName = "ARTICULOS"
            dsGrupo.Tables.Add(DT_ITEM)

            If dsGrupo.Tables("ARTICULOS").Rows.Count = 1 Then

                Details.Codigo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("CODIGO_ARTICULO").ToString
                Details.Nombre = dsGrupo.Tables("ARTICULOS").Rows(0).Item("NOMBRE").ToString
                Details.Codigo_Parte = dsGrupo.Tables("ARTICULOS").Rows(0).Item("CODIGO_PARTE").ToString
                Details.Nombre_Proveedor = dsGrupo.Tables("ARTICULOS").Rows(0).Item("DESCRIPCION_PROVEEDOR").ToString
                Details.Proveedor = IsNull(dsGrupo.Tables("ARTICULOS").Rows(0).Item("PROVEEDOR").ToString, 0)
                Details.Linea = dsGrupo.Tables("ARTICULOS").Rows(0).Item("LINEA").ToString
                Details.Grupo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("GRUPO").ToString
                Details.SubGrupo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("SUBGRUPO").ToString
                Details.S_SubGrupo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("S_SUBGRUPO").ToString
                Details.Modelo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("MODELO").ToString
                Details.Unidad = dsGrupo.Tables("ARTICULOS").Rows(0).Item("UNIDAD").ToString
                Details.Presentacion = dsGrupo.Tables("ARTICULOS").Rows(0).Item("PRESENTACION").ToString
                Details.Ubicacion = dsGrupo.Tables("ARTICULOS").Rows(0).Item("UBICACION").ToString
                Details.Precio_Venta_Cordobas = dsGrupo.Tables("ARTICULOS").Rows(0).Item("PRECIO_VENTA_CORDOBAS").ToString
                Details.Precio_Venta2 = dsGrupo.Tables("ARTICULOS").Rows(0).Item("PRECIO_VENTA2").ToString
                Details.Precio_Venta_Dolar = dsGrupo.Tables("ARTICULOS").Rows(0).Item("PRECIO_VENTA_DOLAR").ToString
                Details.Costo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("COSTO").ToString
                Details.Costo2 = dsGrupo.Tables("ARTICULOS").Rows(0).Item("COSTO2").ToString
                Details.Margen = dsGrupo.Tables("ARTICULOS").Rows(0).Item("MARGEN").ToString
                Details.Costo_Prom = dsGrupo.Tables("ARTICULOS").Rows(0).Item("COSTO_PROM").ToString
                Details.Costo_Ultimo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("COSTO_ULTIMO").ToString
                'Details.Existencia = dsGrupo.Tables("ARTICULOS").Rows(0).Item("EXISTENCIAS").ToString
                Details.Existencia = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Inventario").ToString
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
                Details.Concentracion = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Concentracion").ToString
                Details.via_administracion = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Via_administracion").ToString
                Details.nivel_uso = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Nivel_uso").ToString
                Details.receta = dsGrupo.Tables("ARTICULOS").Rows(0).Item("receta").ToString
                Details.Moneda = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Moneda").ToString
                Details.SKU = dsGrupo.Tables("ARTICULOS").Rows(0).Item("SKU").ToString
                Details.Cultivo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Cultivo").ToString
                Details.CCosto = dsGrupo.Tables("ARTICULOS").Rows(0).Item("CUENTA_COSTO").ToString
                Details.CIngreso = dsGrupo.Tables("ARTICULOS").Rows(0).Item("CUENTA_INGRESO").ToString
                Details.Factor = dsGrupo.Tables("ARTICULOS").Rows(0).Item("FACTOR").ToString
                Details.CDevolucion = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Cta_Devolucion").ToString
                Details.CRebaja = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Cta_Rebajas").ToString
                Details.CentroCosto = dsGrupo.Tables("ARTICULOS").Rows(0).Item("CentroCosto").ToString
                Details.SAC = dsGrupo.Tables("ARTICULOS").Rows(0).Item("SAC")
                Details.Activo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Activo")
                Details.Validar_Precio = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Validar_Precio")
                Details.Obsoleto = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Obsoletos")
                Details.IdProyecto = dsGrupo.Tables("ARTICULOS").Rows(0).Item("IdProyecto")
                Details.IdFabricante = dsGrupo.Tables("ARTICULOS").Rows(0).Item("IdFabricante")
                Details.FactorIngreso = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Factor_UM")
                Details.Marca = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Marca")
                Details.Url = dsGrupo.Tables("ARTICULOS").Rows(0).Item("URL")
                Details.Cabys = dsGrupo.Tables("ARTICULOS").Rows(0).Item("CABYS")
                Details.Impuesto = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Impuesto")
                '
                If dsGrupo.Tables("ARTICULOS").Rows(0).Item("Foto") IsNot DBNull.Value Then
                    Details.Foto = CType(dsGrupo.Tables("ARTICULOS").Rows(0).Item("Foto"), Byte())
                End If

            End If

            Return Details

        End Function

        Public Shared Function GetDetailsTrans(ByVal Codigo As String, ByVal Tipo As String, ByVal Empresa As String) As ArticulosDetails

            'Dim DBCommand As SqlDataAdapter
            Dim dsGrupo As New DataSet
            Dim Details As New ArticulosDetails

            'Dim conexion As New VB.SysContab.Rutinas
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())
            'DBCommand = New SqlDataAdapter("SELECT *,(SELECT isnull(sum(ba.existencia),0) FROM BODEGAS_ARTICULOS ba" _
            '                               + " WHERE ba.codigo_articulo = a.CODIGO_ARTICULO AND ba.empresa = a.EMPRESA) Inventario" _
            '                               + " FROM ARTICULOS a WHERE a.CODIGO_ARTICULO = '" & Codigo & "' AND a.Empresa = '" & Empresa & "' AND a.Tipo = '" & Tipo & "'", DBConnFacturas)

            'DBCommand.SelectCommand.Connection = DBConnFacturas
            'DBCommand.SelectCommand.Transaction = transaccionFacturas
            'DBCommand.Fill(dsGrupo, "ARTICULOS")

            Dim DT_ARTICULOS As DataTable = ObtieneDatosTrans("JAR_GetDetalleProducto",
                                                              Codigo,
                                                              Tipo,
                                                              EmpresaActual)
            dsGrupo.Tables.Add(DT_ARTICULOS)
            dsGrupo.Tables(0).TableName = "ARTICULOS"

            If dsGrupo.Tables("ARTICULOS").Rows.Count = 1 Then
                Details.Codigo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("CODIGO_ARTICULO").ToString
                Details.Nombre = dsGrupo.Tables("ARTICULOS").Rows(0).Item("NOMBRE").ToString
                Details.Proveedor = dsGrupo.Tables("ARTICULOS").Rows(0).Item("PROVEEDOR").ToString
                Details.Linea = dsGrupo.Tables("ARTICULOS").Rows(0).Item("LINEA").ToString
                Details.Grupo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("GRUPO").ToString
                Details.SubGrupo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("SUBGRUPO").ToString
                Details.S_SubGrupo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("S_SUBGRUPO").ToString
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
                'Details.Existencia = dsGrupo.Tables("ARTICULOS").Rows(0).Item("EXISTENCIAS").ToString
                Details.Existencia = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Inventario").ToString
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
                Details.Concentracion = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Concentracion").ToString
                Details.via_administracion = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Via_administracion").ToString
                Details.nivel_uso = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Nivel_uso").ToString
                Details.receta = dsGrupo.Tables("ARTICULOS").Rows(0).Item("receta").ToString
                Details.Moneda = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Moneda").ToString
                Details.SKU = dsGrupo.Tables("ARTICULOS").Rows(0).Item("SKU").ToString
                Details.Cultivo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Cultivo").ToString
                Details.CCosto = dsGrupo.Tables("ARTICULOS").Rows(0).Item("CUENTA_COSTO").ToString
                Details.CIngreso = dsGrupo.Tables("ARTICULOS").Rows(0).Item("CUENTA_INGRESO").ToString                
                Details.Factor = dsGrupo.Tables("ARTICULOS").Rows(0).Item("FACTOR").ToString
                Details.CDevolucion = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Cta_Devolucion").ToString
                Details.CRebaja = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Cta_Rebajas").ToString
                Details.CentroCosto = dsGrupo.Tables("ARTICULOS").Rows(0).Item("CentroCosto").ToString
                Details.SAC = dsGrupo.Tables("ARTICULOS").Rows(0).Item("SAC").ToString
                Details.Activo = dsGrupo.Tables("ARTICULOS").Rows(0).Item("Activo").ToString
            End If

            Return Details
        End Function

        Public Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("Select CODIGO_ARTICULO AS [CODIGO ], ARTICULOS.NOMBRE AS NOMBRE, PROVEEDORES.NOMBRE AS PROVEEDOR FROM ARTICULOS, PROVEEDORES, GRUPOS_INVENTARIO WHERE ARTICULOS.PROVEEDOR = PROVEEDORES.CODIGO AND ARTICULOS.LINEA = GRUPOS_INVENTARIO.CODIGO_GRUPO AND GRUPOS_INVENTARIO.TIPO = 'P' AND ARTICULOS.EMPRESA = '" & Empresa & "'", DBConn)
            DBCommand = New SqlDataAdapter("SELECT ARTICULOS.CODIGO_ARTICULO, ARTICULOS.NOMBRE AS NOMBRE, ARTICULOS.PRECIO_VENTA_CORDOBAS AS PRECIO, ARTICULOS.COSTO AS COSTO, ARTICULOS.EXISTENCIAS AS CANTIDAD, PROVEEDORES.NOMBRE AS PROVEEDOR " & _
                                           "FROM ARTICULOS INNER JOIN PROVEEDORES " & _
                                           "ON ARTICULOS.PROVEEDOR = PROVEEDORES.CODIGO INNER JOIN EMPRESAS " & _
                                           "ON EMPRESAS.CODIGO = ARTICULOS.EMPRESA AND PROVEEDORES.EMPRESA = EMPRESAS.CODIGO " & _
                                           "AND ARTICULOS.TIPO = 'P' AND EMPRESAS.CODIGO = '" & EmpresaActual & "' ORDER BY ARTICULOS.NOMBRE", DBConn)

            DBCommand.Fill(dsFicha, "ARTICULOS")

            DBConn.Close()

            Return dsFicha

        End Function


        Public Function GetListBuscarClientes(ByVal Filtro As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("Select CODIGO_ARTICULO AS [CODIGO ], ARTICULOS.NOMBRE AS NOMBRE, PROVEEDORES.NOMBRE AS PROVEEDOR FROM ARTICULOS, PROVEEDORES, GRUPOS_INVENTARIO WHERE ARTICULOS.PROVEEDOR = PROVEEDORES.CODIGO AND ARTICULOS.LINEA = GRUPOS_INVENTARIO.CODIGO_GRUPO AND GRUPOS_INVENTARIO.TIPO = 'P' AND ARTICULOS.NOMBRE Like '%" & Filtro & "%' AND ARTICULOS.EMPRESA = '" & Empresa & "'", DBConn)
            DBCommand = New SqlDataAdapter("SELECT ARTICULOS.CODIGO_ARTICULO, ARTICULOS.NOMBRE AS NOMBRE, ARTICULOS.PRECIO_VENTA_CORDOBAS AS PRECIO, ARTICULOS.COSTO AS COSTO, ARTICULOS.EXISTENCIAS AS CANTIDAD, PROVEEDORES.NOMBRE AS PROVEEDOR " & _
                                           "FROM ARTICULOS INNER JOIN PROVEEDORES " & _
                                           "ON ARTICULOS.PROVEEDOR = PROVEEDORES.CODIGO INNER JOIN EMPRESAS " & _
                                           "ON EMPRESAS.CODIGO = ARTICULOS.EMPRESA " & _
                                           "AND EMPRESAS.CODIGO = PROVEEDORES.EMPRESA " & _
                                           "AND ARTICULOS.NOMBRE Like '%" & Filtro & "%' AND ARTICULOS.Empresa = '" & EmpresaActual & "' AND ARTICULOS.Tipo ='" & Tipo & "' ORDER BY ARTICULOS.NOMBRE", DBConn)

            DBCommand.Fill(dsFicha, "ARTICULOS")

            DBConn.Close()

            Return dsFicha

        End Function




        Public Function GetListBuscar(ByVal Filtro As String, ByVal Tipo As String, ByVal PC As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())



            If PC = "P" Then
                DBCommand = New SqlDataAdapter("SELECT ARTICULOS.CODIGO_ARTICULO, ARTICULOS.NOMBRE AS NOMBRE, ARTICULOS.PRECIO_VENTA_CORDOBAS AS PRECIO, ARTICULOS.COSTO AS COSTO, ARTICULOS.EXISTENCIAS AS CANTIDAD, PROVEEDORES.NOMBRE AS PROVEEDOR " & _
                                                                                   "FROM ARTICULOS INNER JOIN PROVEEDORES " & _
                                                                                   "ON ARTICULOS.PROVEEDOR = PROVEEDORES.CODIGO INNER JOIN EMPRESAS " & _
                                                                                   "ON EMPRESAS.CODIGO = ARTICULOS.EMPRESA " & _
                                                                                   "AND EMPRESAS.CODIGO = PROVEEDORES.EMPRESA " & _
                                                                                   "AND PC = '" & PC & "'" & _
                                                                                   "AND ARTICULOS.NOMBRE Like '%" & Filtro & "%' AND ARTICULOS.Empresa = '" & EmpresaActual & "' AND ARTICULOS.Tipo ='" & Tipo & "' ORDER BY ARTICULOS.NOMBRE", DBConn)

            End If

            If PC = "C" Then

                DBCommand = New SqlDataAdapter("SELECT ARTICULOS.CODIGO_ARTICULO, ARTICULOS.NOMBRE AS NOMBRE, ARTICULOS.PRECIO_VENTA_CORDOBAS AS PRECIO, ARTICULOS.COSTO AS COSTO, ARTICULOS.EXISTENCIAS AS CANTIDAD, CLIENTES.NOMBRE AS CLIENTES " & _
                                                                   "FROM ARTICULOS INNER JOIN CLIENTES " & _
                                                                   "ON ARTICULOS.PROVEEDOR = CLIENTES.CODIGO INNER JOIN EMPRESAS " & _
                                                                   "ON EMPRESAS.CODIGO = ARTICULOS.EMPRESA " & _
                                                                   "AND EMPRESAS.CODIGO = CLIENTES.EMPRESA " & _
                                                                    "AND PC = '" & PC & "'" & _
                                                                   "AND ARTICULOS.NOMBRE Like '%" & Filtro & "%' AND ARTICULOS.Empresa = '" & EmpresaActual & "' AND ARTICULOS.Tipo ='" & Tipo & "' ORDER BY ARTICULOS.NOMBRE", DBConn)


            End If

            DBCommand.Fill(dsFicha, "ARTICULOS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscarCombo(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("Select CODIGO_ARTICULO, ARTICULOS.NOMBRE AS NOMBRE, PROVEEDORES.NOMBRE AS PROVEEDOR FROM ARTICULOS, PROVEEDORES, GRUPOS_INVENTARIO WHERE ARTICULOS.PROVEEDOR = PROVEEDORES.CODIGO AND ARTICULOS.LINEA = GRUPOS_INVENTARIO.CODIGO_GRUPO AND GRUPOS_INVENTARIO.TIPO = 'P' AND ARTICULOS.NOMBRE Like '" & Filtro & "%' AND ARTICULOS.Empresa = '" & Empresa & "' ORDER BY ARTICULOS.NOMBRE", DBConn)

            DBCommand = New SqlDataAdapter("SELECT CODIGO_ARTICULO, ARTICULOS.NOMBRE AS NOMBRE, PROVEEDORES.NOMBRE AS PROVEEDOR " & _
                                           "FROM ARTICULOS INNER JOIN PROVEEDORES " & _
                                           "ON ARTICULOS.PROVEEDOR = PROVEEDORES.CODIGO INNER JOIN EMPRESAS " & _
                                           "ON EMPRESAS.CODIGO = ARTICULOS.EMPRESA AND PROVEEDORES.EMPRESA = EMPRESAS.CODIGO " & _
                                           "AND ARTICULOS.NOMBRE Like '" & Filtro & "%' AND ARTICULOS.Empresa = '" & Empresa & "' ORDER BY ARTICULOS.NOMBRE", DBConn)



            DBCommand.Fill(dsFicha, "ARTICULOS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListCodigo(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())


            DBCommand = New SqlDataAdapter("Select CODIGO_ARTICULO, Nombre, Nivel, Total From ARTICULOS WHERE CODIGO ='" & Filtro & "' And Empresa = '" & Empresa & "'", DBConn)
            DBCommand.Fill(dsFicha, "ARTICULOS")

            DBConn.Close()

            Return dsFicha

        End Function



        Public Shared Sub Delete(ByVal Codigo As String, ByVal Tipo As String, ByVal PC As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM ARTICULOS WHERE CODIGO_ARTICULO = '" & Codigo & "' And Empresa = '" & EmpresaActual & "' And Tipo = '" & Tipo & "' AND PC='" & PC & "'"

            'Se asigna conexion al comando y se abre conexion 
            'Try
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            'Catch EXC As Exception
            '    MsgBox(EXC.Message)
            'End Try
            DBConn.Close()
        End Sub

        Public Function AddItem(ByVal Codigo As String, ByVal Nombre As String, ByVal Proveedor As String,
                                ByVal Linea As String, ByVal Grupo As String, ByVal SubGrupo As String, ByVal S_SubGrupo As String, ByVal Modelo As String,
                                ByVal Unidad As String, ByVal Presentacion As String, ByVal Ubicacion As String, ByVal PVCordobas As Double, ByVal PVDolar As Double,
                                ByVal Costo As String, ByVal Margen As String, ByVal Costo_Prom As String, ByVal Costo_Ultimo As String, ByVal Existencias As String, ByVal StockMin As String, ByVal StockMax As String,
                                ByVal DescuentoA As String, ByVal DescuentoB As String, ByVal DescuentoC As String, ByVal DescuentoMaximo As String, ByVal Tasa_Cambio As String, ByVal Tipo As String, ByVal Exento As Boolean, ByVal Cuenta As String,
                                ByVal Concentracion As String, ByVal Via_admin As String, ByVal Nivel_de_uso As String, ByVal Receta As String, ByVal Moneda As String, ByVal SKU As String, ByVal Cultivo As String,
                                Optional ByVal Cuenta_Costo As String = "", Optional ByVal Cuenta_Ingreso As String = "", Optional ByVal Factor As Double = 1.0,
                                Optional ByVal Cuenta_Devolucion As String = "", Optional ByVal Cuenta_Rebaja As String = "",
                                Optional ByVal CentroCosto As Integer = 0, Optional sac As String = "", Optional Activo As Integer = 1,
                                Optional Validar_Precio As Integer = 0, Optional Obsoleto As Integer = 0, Optional Precio2 As Double = 0.0, Optional Costo2 As Double = 0.0,
                                Optional IdProyecto As Integer = 0, Optional Codigo_Parte As String = "", Optional Nombre_Proveedor As String = "",
                                Optional Fabricante As Integer = 0, Optional Factor_Ingreso As Double = 1.0, Optional Marca As String = "",
                                Optional Url As String = "", Optional Foto As Byte() = Nothing,
                                Optional Cabys As String = "", Optional Impuesto As Double = 1.0)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_ArticulosAdd", DBConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim _Codigo As SqlParameter = New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim _Nombre As SqlParameter = New SqlParameter("@Nombre", SqlDbType.NVarChar)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim _Linea As SqlParameter = New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim _Grupo As SqlParameter = New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim _SubGrupo As SqlParameter = New SqlParameter("@SubGrupo", SqlDbType.NVarChar)
            Dim _S_SubGrupo As SqlParameter = New SqlParameter("@S_subgrupo", SqlDbType.NVarChar)
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
            Dim _concentra As SqlParameter = New SqlParameter("@concentra", SqlDbType.NVarChar)
            Dim _via As SqlParameter = New SqlParameter("@via", SqlDbType.NVarChar)
            Dim _nivel_uso As SqlParameter = New SqlParameter("@nivel_uso", SqlDbType.NVarChar)
            Dim _receta As SqlParameter = New SqlParameter("@receta", SqlDbType.NVarChar)
            Dim _moneda As SqlParameter = New SqlParameter("@moneda", SqlDbType.NVarChar)
            Dim _sku As SqlParameter = New SqlParameter("@sku", SqlDbType.NVarChar)
            Dim _Cultivo As SqlParameter = New SqlParameter("@Cultivo", SqlDbType.NVarChar)
            Dim _CGosto As SqlParameter = New SqlParameter("@Cuenta_Costo", SqlDbType.NVarChar)
            Dim _CIngreso As SqlParameter = New SqlParameter("@Cuenta_Ingreso", SqlDbType.NVarChar)
            Dim _Factor As SqlParameter = New SqlParameter("@Factor", SqlDbType.Float)
            Dim _CDevolucion As SqlParameter = New SqlParameter("@Cta_Devolucion", SqlDbType.NVarChar)
            Dim _CRebaja As SqlParameter = New SqlParameter("@Cta_Rebajas", SqlDbType.NVarChar)
            Dim _Centro As SqlParameter = New SqlParameter("@Centro", SqlDbType.Int)
            Dim _sac As SqlParameter = New SqlParameter("@sac", SqlDbType.NVarChar)
            Dim _Activo As SqlParameter = New SqlParameter("@Activo", SqlDbType.Int)

            _Codigo.Value = Codigo
            _Nombre.Value = Nombre
            _Proveedor.Value = Proveedor
            _Linea.Value = Linea
            _Grupo.Value = Grupo
            _SubGrupo.Value = SubGrupo
            _S_SubGrupo.Value = S_SubGrupo
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
            _concentra.Value = Concentracion
            _via.Value = Via_admin
            _nivel_uso.Value = Nivel_de_uso
            _receta.Value = Receta
            _moneda.Value = Moneda
            _sku.Value = SKU
            _Cultivo.Value = Cultivo
            _CGosto.Value = Cuenta_Costo
            _CIngreso.Value = Cuenta_Ingreso
            _Factor.Value = Factor
            _CDevolucion.Value = Cuenta_Devolucion
            _CRebaja.Value = Cuenta_Rebaja
            _Centro.Value = CentroCosto
            _sac.Value = sac
            _Activo.Value = Activo

            cmd.Parameters.Add(_Codigo)
            cmd.Parameters.Add(_Nombre)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_Linea)
            cmd.Parameters.Add(_Grupo)
            cmd.Parameters.Add(_SubGrupo)
            cmd.Parameters.Add(_S_SubGrupo)
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
            cmd.Parameters.Add(_concentra)
            cmd.Parameters.Add(_via)
            cmd.Parameters.Add(_nivel_uso)
            cmd.Parameters.Add(_receta)
            cmd.Parameters.Add(_moneda)
            cmd.Parameters.Add(_sku)
            cmd.Parameters.Add(_Cultivo)
            cmd.Parameters.Add(_CGosto)
            cmd.Parameters.Add(_CIngreso)
            cmd.Parameters.Add(_Factor)
            cmd.Parameters.Add(_CDevolucion)
            cmd.Parameters.Add(_CRebaja)
            cmd.Parameters.Add(_Centro)
            cmd.Parameters.Add(_sac)
            cmd.Parameters.Add(_Activo)

            cmd.Parameters.AddWithValue("@Validar_Precio", Validar_Precio)
            cmd.Parameters.AddWithValue("@Obsoleto", Obsoleto)
            cmd.Parameters.AddWithValue("@Precio2", Precio2)
            cmd.Parameters.AddWithValue("@Costo2", Costo2)
            cmd.Parameters.AddWithValue("@IdProyecto", IdProyecto)
            cmd.Parameters.AddWithValue("@Codigo_Parte", Codigo_Parte)
            cmd.Parameters.AddWithValue("@Nombre_Proveedor", Nombre_Proveedor)
            cmd.Parameters.AddWithValue("@IdFabricante", Fabricante)
            cmd.Parameters.AddWithValue("@Factor_UM", Factor_Ingreso)
            cmd.Parameters.AddWithValue("@Marca", Marca)
            cmd.Parameters.AddWithValue("@Url", Url)
            cmd.Parameters.AddWithValue("@Foto", Foto)
            cmd.Parameters.AddWithValue("@Cabys", Cabys)
            cmd.Parameters.AddWithValue("@Impuesto", Impuesto)

            ' Open the connection and execute the Command
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()
        End Function

        Public Function Update(ByVal Codigo As String, ByVal Nombre As String, ByVal Proveedor As String,
                        ByVal Linea As String, ByVal Grupo As String, ByVal SubGrupo As String, ByVal S_SubGrupo As String,
                        ByVal Modelo As String, ByVal Unidad As String, ByVal Presentacion As String, ByVal Ubicacion As String,
                        ByVal PVCordobas As String, ByVal PVDolar As String, ByVal Costo As String, ByVal Margen As String,
                        ByVal Existencias As String, ByVal StockMin As String, ByVal StockMax As String,
                        ByVal DescuentoA As String, ByVal DescuentoB As String, ByVal DescuentoC As String,
                        ByVal DescuentoMaximo As String, ByVal Tasa_Cambio As String, ByVal Exento As Integer,
                        ByVal Cuenta As String, ByVal Concentracion As String, ByVal Via_admin As String,
                        ByVal Nivel_de_uso As String, ByVal Receta As String, ByVal Tipo As String, ByVal Moneda As String, ByVal SKU As String, ByVal Cultivo As String,
                        Optional ByVal Cuenta_Costo As String = "", Optional ByVal Cuenta_Ingreso As String = "", Optional ByVal Factor As Double = 1.0,
                        Optional ByVal Cuenta_Devolucion As String = "", Optional ByVal Cuenta_Rebaja As String = "",
                        Optional ByVal CentroCosto As Integer = 0, Optional sac As String = "", Optional Activo As Integer = 1,
                        Optional Validar_Precio As Integer = 0, Optional Obsoleto As Integer = 0, Optional Precio2 As Double = 0.0, Optional Costo2 As Double = 0.0,
                        Optional IdProyecto As Integer = 0, Optional Codigo_Parte As String = "", Optional Nombre_Proveedor As String = "",
                        Optional Fabricante As Integer = 0, Optional Factor_Ingreso As Double = 1.0, Optional Marca As String = "",
                        Optional Url As String = "", Optional Foto As Byte() = Nothing,
                               Optional Cabys As String = "", Optional Impuesto As Double = 1.0)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_ArticulosUpdate", DBConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim _Codigo As SqlParameter = New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim _Nombre As SqlParameter = New SqlParameter("@Nombre", SqlDbType.NVarChar)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim _Linea As SqlParameter = New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim _Grupo As SqlParameter = New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim _SubGrupo As SqlParameter = New SqlParameter("@SubGrupo", SqlDbType.NVarChar)
            Dim _S_SubGrupo As SqlParameter = New SqlParameter("@S_subgrupo", SqlDbType.NVarChar)
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
            Dim _concentra As SqlParameter = New SqlParameter("@concentra", SqlDbType.NVarChar)
            Dim _via As SqlParameter = New SqlParameter("@via", SqlDbType.NVarChar)
            Dim _nivel_uso As SqlParameter = New SqlParameter("@nivel_uso", SqlDbType.NVarChar)
            Dim _receta As SqlParameter = New SqlParameter("@receta", SqlDbType.NVarChar)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim _moneda As SqlParameter = New SqlParameter("@Moneda", SqlDbType.NVarChar)
            Dim _sku As SqlParameter = New SqlParameter("@sku", SqlDbType.NVarChar)
            Dim _Cultivo As SqlParameter = New SqlParameter("@Cultivo", SqlDbType.NVarChar)
            Dim _CCosto As SqlParameter = New SqlParameter("@Cuenta_Costo", SqlDbType.NVarChar)
            Dim _CIngreso As SqlParameter = New SqlParameter("@Cuenta_Ingreso", SqlDbType.NVarChar)
            Dim _Factor As SqlParameter = New SqlParameter("@Factor", SqlDbType.Float)
            Dim _CDevolucion As SqlParameter = New SqlParameter("@Cta_Devolucion", SqlDbType.NVarChar)
            Dim _CRebaja As SqlParameter = New SqlParameter("@Cta_Rebajas", SqlDbType.NVarChar)
            Dim _Centro As SqlParameter = New SqlParameter("@Centro", SqlDbType.Int)
            Dim _sac As SqlParameter = New SqlParameter("@sac", SqlDbType.NVarChar)
            Dim _Activo As SqlParameter = New SqlParameter("@Activo", SqlDbType.Int)

            _Codigo.Value = Codigo
            _Nombre.Value = Nombre
            _Proveedor.Value = Proveedor
            _Linea.Value = Linea
            _Grupo.Value = Grupo
            _SubGrupo.Value = SubGrupo
            _S_SubGrupo.Value = S_SubGrupo
            _Modelo.Value = Modelo
            _Unidad.Value = Unidad
            _Presentacion.Value = Presentacion
            _Ubicacion.Value = Ubicacion
            _PVCordobas.Value = IIf(PVCordobas Is String.Empty, 0, PVCordobas)
            _PVDolar.Value = IIf(PVDolar Is String.Empty, 0, PVDolar)
            _Costo.Value = IIf(Costo Is String.Empty, 0, Costo)
            _Margen.Value = IIf(Margen Is String.Empty, 0, Margen)
            _Existencias.Value = IIf(Existencias Is String.Empty, 0, Existencias)
            _StockMin.Value = IIf(StockMin Is String.Empty, 0, StockMin)
            _StockMax.Value = IIf(StockMax Is String.Empty, 0, StockMax)
            _DescuentoA.Value = IIf(DescuentoA Is String.Empty, 0, DescuentoA)
            _DescuentoB.Value = IIf(DescuentoB Is String.Empty, 0, DescuentoB)
            _DescuentoC.Value = IIf(DescuentoC Is String.Empty, 0, DescuentoC)
            _DescuentoMaximo.Value = IIf(DescuentoMaximo Is String.Empty, 0, DescuentoMaximo)
            _Tasa_Cambio.Value = IIf(Tasa_Cambio Is String.Empty, 0, Tasa_Cambio)
            _Exento.Value = Exento
            _Cuenta.Value = Cuenta
            _Empresa.Value = EmpresaActual
            _concentra.Value = IIf(Concentracion Is String.Empty, "", Concentracion)
            _via.Value = IIf(Via_admin Is String.Empty, "", Via_admin)
            _nivel_uso.Value = IIf(Nivel_de_uso Is String.Empty, "", Nivel_de_uso)
            _receta.Value = IIf(Receta Is String.Empty, "", Receta)
            _Tipo.Value = Tipo
            _moneda.Value = Moneda
            _sku.Value = SKU
            _Cultivo.Value = Cultivo
            _CCosto.Value = Cuenta_Costo
            _CIngreso.Value = Cuenta_Ingreso
            _Factor.Value = Factor
            _CDevolucion.Value = Cuenta_Devolucion
            _CRebaja.Value = Cuenta_Rebaja
            _Centro.Value = CentroCosto
            _sac.Value = sac
            _Activo.Value = Activo

            cmd.Parameters.Add(_Codigo)
            cmd.Parameters.Add(_Nombre)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_Linea)
            cmd.Parameters.Add(_Grupo)
            cmd.Parameters.Add(_SubGrupo)
            cmd.Parameters.Add(_S_SubGrupo)
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
            cmd.Parameters.Add(_concentra)
            cmd.Parameters.Add(_via)
            cmd.Parameters.Add(_nivel_uso)
            cmd.Parameters.Add(_receta)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_moneda)
            cmd.Parameters.Add(_sku)
            cmd.Parameters.Add(_Cultivo)
            cmd.Parameters.Add(_CCosto)
            cmd.Parameters.Add(_CIngreso)
            cmd.Parameters.Add(_Factor)
            cmd.Parameters.Add(_CDevolucion)
            cmd.Parameters.Add(_CRebaja)
            cmd.Parameters.Add(_Centro)
            cmd.Parameters.Add(_sac)
            cmd.Parameters.Add(_Activo)

            cmd.Parameters.AddWithValue("@Validar_Precio", Validar_Precio)
            cmd.Parameters.AddWithValue("@Obsoleto", Obsoleto)
            cmd.Parameters.AddWithValue("@Precio2", Precio2)
            cmd.Parameters.AddWithValue("@Costo2", Costo2)
            cmd.Parameters.AddWithValue("@IdProyecto", IdProyecto)
            cmd.Parameters.AddWithValue("@Codigo_Parte", Codigo_Parte)
            cmd.Parameters.AddWithValue("@Nombre_Proveedor", Nombre_Proveedor)
            cmd.Parameters.AddWithValue("@IdFabricante", Fabricante)
            cmd.Parameters.AddWithValue("@Factor_UM", Factor_Ingreso)
            cmd.Parameters.AddWithValue("@Marca", Marca)
            cmd.Parameters.AddWithValue("@Url", Url)
            cmd.Parameters.AddWithValue("@Foto", Foto)
            cmd.Parameters.AddWithValue("@Cabys", Cabys)
            cmd.Parameters.AddWithValue("@Impuesto", Impuesto)

            ' Open the connection and execute the Command
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()
        End Function

        Public Shared Function AntiguedadInventario(Hasta As Date, Bodega As String, Moneda As String) As DataTable
            Try
                Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
                Conn.RemoveParameters()

                Conn.AddParameter("Hasta", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Hasta.Date)
                Conn.AddParameter("Bodega", SqlDbType.NVarChar, 512, ParameterDirection.Input, Bodega)
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                Conn.AddParameter("Moneda", SqlDbType.NVarChar, 10, ParameterDirection.Input, Moneda)

                Return Conn.EjecutarComando("JAR_AntiguedadInventario_v2")
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
                Return Nothing
            End Try

        End Function

        Public Shared Sub UpdateCabys(Codigo As String, Tipo As String, Cabys As String, Impuesto As Double)
            Try
                Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())

                Conn.RemoveParameters()
                Conn.AddParameter("Codigo", SqlDbType.NVarChar, 50, ParameterDirection.Input, Codigo)
                Conn.AddParameter("Tipo", SqlDbType.NVarChar, 5, ParameterDirection.Input, Tipo)
                Conn.AddParameter("Cabys", SqlDbType.NVarChar, 50, ParameterDirection.Input, Cabys)
                Conn.AddParameter("Impuesto", SqlDbType.Decimal, 18, ParameterDirection.Input, Impuesto)
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)

                Conn.EjecutarComando("sp_sel_ARTICULOS_CABYS")

            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
            End Try
        End Sub


        Public Shared Function AntiguedadDeLoVendido(Desde As Date, Hasta As Date, Bodega As String, Moneda As String) As DataTable

            Try
                Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())

                Conn.RemoveParameters()
                Conn.AddParameter("Desde", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Desde.Date)
                Conn.AddParameter("Hasta", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Hasta.Date)
                Conn.AddParameter("Bodega", SqlDbType.NVarChar, 512, ParameterDirection.Input, Bodega)
                Conn.AddParameter("Moneda", SqlDbType.NVarChar, 512, ParameterDirection.Input, Moneda)
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)

                Return Conn.EjecutarComando("JAR_AntiguedadVentas")

            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
                Return Nothing
            End Try

        End Function


    End Class
End Namespace
