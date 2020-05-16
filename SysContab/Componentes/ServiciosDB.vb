Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class ServiciosDetails
        Public Codigo As String
        Public Nombre As String
        Public Proveedor As String
        Public Linea As String
        Public Grupo As String
        Public SubGrupo As String
        Public S_SubGrupo As String
        Public Costo As String
        Public Margen As String
        Public Costo_Promedio As String
        Public Costo_Ultimo As String
        Public Precio As String
        Public Numero_Horas As String
        Public Precio_Hora As String
        Public Minimo_Horas As String
        Public Incremento As String
        Public Precio_Minimo As String

        Public Descuento_A As String
        Public Descuento_B As String
        Public Descuento_C As String

        Public Gasto_Transporte As String
        Public Gasto_Material As String
        Public Gasto_Personal As String
        Public Gasto_Externo As String
        Public Cuenta As String
        Public Exento As Boolean
        Public Kilometraje As Boolean
        Public Descuento As Boolean
        Public Centro As Integer

        'Public Valor_Transporte As String
        'Public Valor_Material As String
        'Public Valor_Personal As String
        'Public Valor_Externo As String

        'Public Nombre_Linea As String
        'Public Nombre_Grupo As String
        'Public Nombre_SubGrupo As String
        'Public Nombre_Proveedor As String

    End Class

    Public Class ServiciosDB

        Public Function ServiciosGetAll() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ServiciosGetAll", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Servicios")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GeneradorReportes(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GeneradorReportesServicios", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pFiltro As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            'Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            'Dim pLinea As New SqlParameter("@Linea", SqlDbType.Int)
            'Dim pOrden As New SqlParameter("@Orden", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual
            pFiltro.Value = Filtro
            'pProveedor.Value = Proveedor
            'pLinea.Value = Linea
            'pOrden.Value = Orden

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pFiltro)
            'DBCommand.SelectCommand.Parameters.Add(pProveedor)
            'DBCommand.SelectCommand.Parameters.Add(pLinea)
            'DBCommand.SelectCommand.Parameters.Add(pOrden)

            DBCommand.Fill(dsFicha, "Servicios")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetVentas(ByVal Servicio As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetAcumuladosServicios", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pServicio As New SqlParameter("@Producto", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pServicio.Value = Servicio
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pServicio)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetDetails(ByVal Codigo As String, ByVal Tipo As String, ByVal PC As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsArticulos As New DataSet
            Dim Details As New ServiciosDetails

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT * FROM ARTICULOS WHERE CODIGO_SERVICIO = '" & Codigo & "' AND TIPO = '" & Tipo & "' AND EMPRESA = '" & EmpresaActual & "'", DBConn)
            DBCommand = New SqlDataAdapter("SELECT * FROM ARTICULOS WHERE CODIGO_ARTICULO = '" & Codigo & "' And Empresa = '" & EmpresaActual & "' AND Tipo = '" & Tipo & "' AND PC='" & PC & "'", DBConn)


            DBCommand.Fill(dsArticulos, "ARTICULOS")

            If dsArticulos.Tables("Articulos").Rows.Count = 1 Then
                Details.Codigo = dsArticulos.Tables("Articulos").Rows(0).Item("CODIGO_ARTICULO").ToString
                Details.Nombre = dsArticulos.Tables("Articulos").Rows(0).Item("NOMBRE").ToString
                Details.Proveedor = dsArticulos.Tables("Articulos").Rows(0).Item("PROVEEDOR").ToString
                Details.Linea = dsArticulos.Tables("Articulos").Rows(0).Item("LINEA").ToString
                Details.Grupo = dsArticulos.Tables("Articulos").Rows(0).Item("GRUPO").ToString
                Details.SubGrupo = dsArticulos.Tables("Articulos").Rows(0).Item("SUBGRUPO").ToString
                Details.S_SubGrupo = dsArticulos.Tables("ARTICULOS").Rows(0).Item("S_SUBGRUPO").ToString
                Details.Costo = dsArticulos.Tables("Articulos").Rows(0).Item("COSTO").ToString
                Details.Margen = dsArticulos.Tables("Articulos").Rows(0).Item("MARGEN").ToString
                Details.Costo_Promedio = dsArticulos.Tables("Articulos").Rows(0).Item("COSTO_PROM").ToString
                Details.Costo_Ultimo = dsArticulos.Tables("Articulos").Rows(0).Item("COSTO_ULTIMO").ToString

                Details.Precio = dsArticulos.Tables("Articulos").Rows(0).Item("PRECIO_VENTA_CORDOBAS").ToString
                Details.Numero_Horas = IIf(dsArticulos.Tables("Articulos").Rows(0).Item("NUMERO_HORAS").ToString Is String.Empty, 0, dsArticulos.Tables("Articulos").Rows(0).Item("NUMERO_HORAS").ToString)
                Details.Precio_Hora = IIf(dsArticulos.Tables("Articulos").Rows(0).Item("PRECIO_HORA").ToString Is String.Empty, 0, dsArticulos.Tables("Articulos").Rows(0).Item("PRECIO_HORA").ToString)
                Details.Minimo_Horas = IIf(dsArticulos.Tables("Articulos").Rows(0).Item("MINIMO_HORAS").ToString Is String.Empty, 0, dsArticulos.Tables("Articulos").Rows(0).Item("MINIMO_HORAS").ToString)
                Details.Incremento = IIf(dsArticulos.Tables("Articulos").Rows(0).Item("INCREMENTO").ToString Is String.Empty, 0, dsArticulos.Tables("Articulos").Rows(0).Item("INCREMENTO").ToString)
                Details.Precio_Minimo = IIf(dsArticulos.Tables("Articulos").Rows(0).Item("PRECIO_MINIMO").ToString Is String.Empty, 0, dsArticulos.Tables("Articulos").Rows(0).Item("PRECIO_MINIMO").ToString)

                Details.Descuento_A = dsArticulos.Tables("Articulos").Rows(0).Item("DESCUENTO_A").ToString
                Details.Descuento_B = dsArticulos.Tables("Articulos").Rows(0).Item("DESCUENTO_B").ToString
                Details.Descuento_C = dsArticulos.Tables("Articulos").Rows(0).Item("DESCUENTO_C").ToString

                Details.Gasto_Transporte = IIf(dsArticulos.Tables("Articulos").Rows(0).Item("GASTO_TRANSPORTE").ToString Is String.Empty, 0, dsArticulos.Tables("Articulos").Rows(0).Item("GASTO_TRANSPORTE").ToString)
                Details.Gasto_Material = IIf(dsArticulos.Tables("Articulos").Rows(0).Item("GASTO_MATERIAL").ToString Is String.Empty, 0, dsArticulos.Tables("Articulos").Rows(0).Item("GASTO_MATERIAL").ToString)
                Details.Gasto_Personal = IIf(dsArticulos.Tables("Articulos").Rows(0).Item("GASTO_PERSONAL").ToString Is String.Empty, 0, dsArticulos.Tables("Articulos").Rows(0).Item("GASTO_PERSONAL").ToString)
                Details.Gasto_Externo = IIf(dsArticulos.Tables("Articulos").Rows(0).Item("GASTO_EXTERNO").ToString Is String.Empty, 0, dsArticulos.Tables("Articulos").Rows(0).Item("GASTO_EXTERNO").ToString)
                Details.Exento = dsArticulos.Tables("Articulos").Rows(0).Item("Exento")
                Details.Kilometraje = dsArticulos.Tables("Articulos").Rows(0).Item("Kilometraje")
                Details.Descuento = dsArticulos.Tables("Articulos").Rows(0).Item("Descuento")
                Details.Centro = dsArticulos.Tables("Articulos").Rows(0).Item("CentroCosto")

                Details.Cuenta = IIf(dsArticulos.Tables("Articulos").Rows(0).Item("Cuenta") Is DBNull.Value, "", dsArticulos.Tables("Articulos").Rows(0).Item("Cuenta").ToString)
                'Details.Valor_Transporte = dsArticulos.Tables("Articulos").Rows(0).Item("VALOR_TRANSPORTE")
                'Details.Valor_Material = dsArticulos.Tables("Articulos").Rows(0).Item("VALOR_MATERIAL")
                'Details.Valor_Personal = dsArticulos.Tables("Articulos").Rows(0).Item("VALOR_PERSONAL")
                'Details.Valor_Externo = dsArticulos.Tables("Articulos").Rows(0).Item("VALOR_EXTERNO")
            End If
            Return Details

        End Function

        Public Function GetList(ByVal PC As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())


            If PC = "P" Then

                DBCommand = New SqlDataAdapter("SELECT ARTICULOS.CODIGO_ARTICULO AS Código, ARTICULOS.NOMBRE AS Nombre, PROVEEDORES.NOMBRE AS Proveedor,ARTICULOS.CUENTA, PC, " & _
                                                "COSTO,cast(isnull(ARTICULOS.Exento,0) AS bit) Exento " & _
                                                "FROM ARTICULOS INNER JOIN PROVEEDORES " & _
                                                "ON ARTICULOS.PROVEEDOR = PROVEEDORES.CODIGO INNER JOIN EMPRESAS " & _
                                                "ON EMPRESAS.CODIGO = ARTICULOS.EMPRESA AND PROVEEDORES.EMPRESA = EMPRESAS.CODIGO " & _
                                                "AND ARTICULOS.TIPO = 'S' AND EMPRESAS.CODIGO = '" & EmpresaActual & "' WHERE PC = '" & PC & "' Order By Codigo_Articulo", DBConn)




            ElseIf PC = "C" Then

                DBCommand = New SqlDataAdapter("SELECT ARTICULOS.CODIGO_ARTICULO as Código, ARTICULOS.NOMBRE AS Nombre, CLIENTES.NOMBRE AS Cliente,ARTICULOS.CUENTA, PC " & _
                                           "FROM ARTICULOS INNER JOIN CLIENTES " & _
                                           "ON ARTICULOS.PROVEEDOR = CLIENTES.CODIGO INNER JOIN EMPRESAS " & _
                                           "ON EMPRESAS.CODIGO = ARTICULOS.EMPRESA AND CLIENTES.EMPRESA = EMPRESAS.CODIGO " & _
                                           "AND ARTICULOS.TIPO = 'S' AND EMPRESAS.CODIGO = '" & EmpresaActual & "' WHERE PC = '" & PC & "' Order By Codigo_Articulo", DBConn)



            End If



            DBCommand.Fill(dsFicha, "ARTICULOS")
            DBConn.Close()

            Return dsFicha
        End Function

        '07/11/2005
        ''''''Public Function GetList(ByVal Empresa As String) As DataSet
        ''''''    Dim DBConn As SqlConnection
        ''''''    Dim DBCommand As SqlDataAdapter
        ''''''    Dim dsFicha As New DataSet()

        ''''''    Dim conexion As New VB.SysContab.Rutinas()
        ''''''    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        ''''''    'DBCommand = New SqlDataAdapter("Select CODIGO_ARTICULO AS [CODIGO ], ARTICULOS.NOMBRE AS NOMBRE, PROVEEDORES.NOMBRE AS PROVEEDOR FROM ARTICULOS, PROVEEDORES, GRUPOS_INVENTARIO WHERE ARTICULOS.PROVEEDOR = PROVEEDORES.CODIGO AND ARTICULOS.LINEA = GRUPOS_INVENTARIO.CODIGO_GRUPO AND GRUPOS_INVENTARIO.TIPO = 'P' AND ARTICULOS.EMPRESA = '" & Empresa & "'", DBConn)
        ''''''    DBCommand = New SqlDataAdapter("SELECT SERVICIOS.CODIGO_SERVICIO, SERVICIOS.NOMBRE AS NOMBRE, PROVEEDORES.NOMBRE AS PROVEEDOR " & _
        ''''''                                   "FROM SERVICIOS INNER JOIN PROVEEDORES " & _
        ''''''                                   "ON SERVICIOS.PROVEEDOR = PROVEEDORES.CODIGO INNER JOIN EMPRESAS " & _
        ''''''                                   "ON EMPRESAS.CODIGO = SERVICIOS.EMPRESA AND PROVEEDORES.EMPRESA = EMPRESAS.CODIGO " & _
        ''''''                                   "AND EMPRESAS.CODIGO = '" & Empresa & "'", DBConn)

        ''''''    DBCommand.Fill(dsFicha, "SERVICIOS")

        ''''''    DBConn.Close()

        ''''''    Return dsFicha

        ''''''End Function

        Public Function GetListBuscar(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("Select CODIGO_ARTICULO AS [CODIGO ], ARTICULOS.NOMBRE AS NOMBRE, PROVEEDORES.NOMBRE AS PROVEEDOR FROM ARTICULOS, PROVEEDORES, GRUPOS_INVENTARIO WHERE ARTICULOS.PROVEEDOR = PROVEEDORES.CODIGO AND ARTICULOS.LINEA = GRUPOS_INVENTARIO.CODIGO_GRUPO AND GRUPOS_INVENTARIO.TIPO = 'P' AND ARTICULOS.NOMBRE Like '%" & Filtro & "%' AND ARTICULOS.EMPRESA = '" & Empresa & "'", DBConn)
            DBCommand = New SqlDataAdapter("SELECT CODIGO_SERVICIO, SERVICIOS.NOMBRE AS NOMBRE, PROVEEDORES.NOMBRE AS PROVEEDOR " & _
                                           "FROM SERVICIOS INNER JOIN PROVEEDORES " & _
                                           "ON SERVICIOS.PROVEEDOR = PROVEEDORES.CODIGO INNER JOIN EMPRESAS " & _
                                           "ON EMPRESAS.CODIGO = SERVICIOS.EMPRESA " & _
                                           "AND SERVICIOS.NOMBRE Like '%" & Filtro & "%' AND SERVICIOS.Empresa = '" & Empresa & "' ORDER BY SERVICIOS.NOMBRE", DBConn)

            DBCommand.Fill(dsFicha, "SERVICIOS")

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

            DBCommand = New SqlDataAdapter("SELECT CODIGO_SERVICIO, SERVICIOS.NOMBRE AS NOMBRE, PROVEEDORES.NOMBRE AS PROVEEDOR " & _
                                           "FROM SERVICIOS INNER JOIN PROVEEDORES " & _
                                           "ON SERVICIOS.PROVEEDOR = PROVEEDORES.CODIGO INNER JOIN EMPRESAS " & _
                                           "ON EMPRESAS.CODIGO = SERVICIOS.EMPRESA AND PROVEEDORES.EMPRESA = EMPRESAS.CODIGO " & _
                                           "AND SERVICIOS.NOMBRE Like '" & Filtro & "%' AND SERVICIOS.Empresa = '" & Empresa & "' ORDER BY SERVICIOS.NOMBRE", DBConn)



            DBCommand.Fill(dsFicha, "SERVICIOS")

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


            DBCommand = New SqlDataAdapter("Select CODIGO_SERVICIO, Nombre, Nivel, Total From ARTICULOS WHERE CODIGO ='" & Filtro & "' And Empresa = '" & Empresa & "'", DBConn)
            DBCommand.Fill(dsFicha, "SERVICIOS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function Delete(ByVal Codigo As String, ByVal Empresa As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM SERVICIOS WHERE CODIGO_SERVICIO = '" & Codigo & "' And Empresa = '" & Empresa & "'"

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

        Public Function AddItem(ByVal Codigo As String, ByVal Nombre As String, ByVal Proveedor As String, _
                                 ByVal Linea As String, ByVal Grupo As String, ByVal SubGrupo As String, ByVal S_SubGrupo As String, _
                                 ByVal Costo As String, ByVal Margen As String, ByVal Costo_Promedio As String, _
                                 ByVal Costo_Ultimo As String, ByVal Precio As String, ByVal Numero_Horas As String, _
                                 ByVal Precio_Hora As String, ByVal Minimo_Horas As String, ByVal Incremento As String, _
                                 ByVal Precio_Minimo As String, ByVal DescuentoA As String, ByVal DescuentoB As String, _
                                 ByVal DescuentoC As String, ByVal Gasto_Transporte As String, _
                                 ByVal Gasto_Material As String, ByVal Gasto_Personal As String, _
                                 ByVal Gasto_Externo As String, ByVal Cuenta As String, ByVal Exento As Boolean, ByVal PC As String, _
                                 Kilometraje As Integer, Descuento As Integer, Centro As Integer)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Articulos(PC, CODIGO_ARTICULO, NOMBRE, PROVEEDOR, LINEA, GRUPO, SUBGRUPO, S_SUBGRUPO,COSTO, MARGEN, " & _
                            " COSTO_PROM, COSTO_ULTIMO, PRECIO_VENTA_CORDOBAS, NUMERO_HORAS, PRECIO_HORA, MINIMO_HORAS, INCREMENTO, " & _
                            " PRECIO_MINIMO, DESCUENTO_A, DESCUENTO_B, DESCUENTO_C, GASTO_TRANSPORTE, GASTO_MATERIAL, GASTO_PERSONAL, " & _
                            " GASTO_EXTERNO, TIPO, EMPRESA, CUENTA,EXENTO, Kilometraje, Descuento, CentroCosto) " & _
                            " Values('" & PC & "', '" & Codigo & "','" & Nombre & "','" & Proveedor & "','" & Linea & "','" & Grupo & "','" & SubGrupo & "','" & S_SubGrupo & "','" & Costo & "','" & Margen & "','" & Costo_Promedio & "','" & Costo_Ultimo & "','" & Precio & "','" & Numero_Horas & "','" & Precio_Hora & "','" & Minimo_Horas & "','" & Incremento & "','" & Precio_Minimo & "','" & DescuentoA & "','" & DescuentoB & "','" & DescuentoC & "','" & Gasto_Transporte & "','" & Gasto_Material & "','" & Gasto_Personal & "','" & Gasto_Externo & "','S','" & EmpresaActual & "','" & Cuenta & "'," & IIf(Exento, 1, 0) & "," & Kilometraje & "," & Descuento & "," & Centro & ")"

            'Se asigna conexion al comando y se abre conexion 

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function Update(ByVal Codigo As String, ByVal Nombre As String, ByVal Proveedor As String, _
                               ByVal Linea As String, ByVal Grupo As String, ByVal SubGrupo As String, ByVal S_SubGrupo As String, _
                               ByVal Costo As Double, ByVal Margen As Double, ByVal Costo_Promedio As Double, _
                               ByVal Costo_Ultimo As Double, ByVal Precio As Double, ByVal Numero_Horas As Double, _
                               ByVal Precio_Hora As Double, ByVal Minimo_Horas As Double, ByVal Incremento As Double, _
                               ByVal Precio_Minimo As Double, ByVal DescuentoA As Double, ByVal DescuentoB As Double, _
                               ByVal DescuentoC As Double, ByVal Gasto_Transporte As Double, _
                               ByVal Gasto_Material As Double, ByVal Gasto_Personal As Double, _
                               ByVal Gasto_Externo As Double, ByVal Cuenta As String, ByVal Exento As Boolean, ByVal PC As String, _
                               Kilometraje As Integer, Descuento As Integer, Centro As Integer)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE Articulos SET NOMBRE = '" & Nombre & "', " & _
                              "PROVEEDOR = '" & Proveedor & "', " & _
                              "LINEA = '" & Linea & "', " & _
                              "CUENTA = '" & Cuenta & "', " & _
                              "GRUPO = '" & Grupo & "', " & _
                              "SUBGRUPO = '" & SubGrupo & "', " & _
                              "S_SUBGRUPO = '" & S_SubGrupo & "', " & _
                              "COSTO = " & Costo & ", " & _
                              "MARGEN = " & Margen & ", " & _
                              "PRECIO_VENTA_CORDOBAS = " & Precio & ", " & _
                              "NUMERO_HORAS = " & Numero_Horas & ", " & _
                              "PRECIO_HORA = " & Precio_Hora & ", " & _
                              "MINIMO_HORAS = " & Minimo_Horas & ", " & _
                              "INCREMENTO = " & Incremento & ", " & _
                              "PRECIO_MINIMO = " & Precio_Minimo & ", " & _
                              "DESCUENTO_A = " & DescuentoA & ", " & _
                              "DESCUENTO_B = " & DescuentoB & ", " & _
                              "DESCUENTO_C = " & DescuentoC & ", " & _
                              "GASTO_TRANSPORTE = " & Gasto_Transporte & ", " & _
                              "GASTO_MATERIAL = " & Gasto_Material & ", " & _
                              "GASTO_PERSONAL = " & Gasto_Personal & ", " & _
                              "GASTO_EXTERNO = " & Gasto_Externo & ", " & _
                              "Kilometraje = " & Kilometraje & ", " & _
                              "Descuento = " & Descuento & ", " & _
                              "CentroCosto = " & Centro & ", " & _
                              "EXENTO = " & IIf(Exento, 1, 0) & " " & _
                              "WHERE CODIGO_ARTICULO = '" & Codigo & "' AND EMPRESA = '" & EmpresaActual & "' AND Tipo = 'S' AND PC = '" & PC & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function
    End Class
End Namespace
