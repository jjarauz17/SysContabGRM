Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class GruposCCDB

        Public Function ArticulosCCUltimaCompra(ByVal Item As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosCCUltimaCompra", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Item.Value = Item
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Item)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ArticulosCCUltimaSalida(ByVal Item As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosCCUltimaSalida", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Item.Value = Item
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Item)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function SalidasListReporte(ByVal Area As String, ByVal Fecha1 As String, ByVal Fecha2 As String, ByVal Proveedor As String, ByVal Codigo As String, ByVal Nombre As String, ByVal Linea As String, ByVal Grupo As String, ByVal SubGrupo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_SalidasCCReportes", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Area As New SqlParameter("@Area", SqlDbType.NVarChar)
            Dim _Fecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim _Fecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim _Proveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            Dim _Codigo As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim _Nombre As New SqlParameter("@Nombre", SqlDbType.NVarChar)
            Dim _Linea As New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim _Grupo As New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim _SubGrupo As New SqlParameter("@SubGrupo", SqlDbType.NVarChar)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)

            _Area.Value = Area
            _Fecha1.Value = Fecha1
            _Fecha2.Value = Fecha2
            _Proveedor.Value = Proveedor
            _Codigo.Value = Codigo
            _Nombre.Value = Nombre
            _Linea.Value = Linea
            _Grupo.Value = Grupo
            _SubGrupo.Value = SubGrupo
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Area)
            DBCommand.SelectCommand.Parameters.Add(_Fecha1)
            DBCommand.SelectCommand.Parameters.Add(_Fecha2)
            DBCommand.SelectCommand.Parameters.Add(_Proveedor)
            DBCommand.SelectCommand.Parameters.Add(_Codigo)
            DBCommand.SelectCommand.Parameters.Add(_Nombre)
            DBCommand.SelectCommand.Parameters.Add(_Linea)
            DBCommand.SelectCommand.Parameters.Add(_Grupo)
            DBCommand.SelectCommand.Parameters.Add(_SubGrupo)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Tabla")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ArticulosCCLista(ByVal Item As String, ByVal Proveedor As String, ByVal Linea As String, ByVal Grupo As String, ByVal SubGrupo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosCCLista", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim _Linea As SqlParameter = New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim _Grupo As SqlParameter = New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim _SubGrupo As SqlParameter = New SqlParameter("@SubGrupo", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Item.Value = Item
            _Proveedor.Value = Proveedor
            _Linea.Value = Linea
            _Grupo.Value = Grupo
            _SubGrupo.Value = SubGrupo
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Item)
            DBCommand.SelectCommand.Parameters.Add(_Proveedor)
            DBCommand.SelectCommand.Parameters.Add(_Linea)
            DBCommand.SelectCommand.Parameters.Add(_Grupo)
            DBCommand.SelectCommand.Parameters.Add(_SubGrupo)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ArticulosCCMinimo(ByVal Item As String, ByVal Proveedor As String, ByVal Linea As String, ByVal Grupo As String, ByVal SubGrupo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosCCMinimo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim _Linea As SqlParameter = New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim _Grupo As SqlParameter = New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim _SubGrupo As SqlParameter = New SqlParameter("@SubGrupo", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Item.Value = Item
            _Proveedor.Value = Proveedor
            _Linea.Value = Linea
            _Grupo.Value = Grupo
            _SubGrupo.Value = SubGrupo
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Item)
            DBCommand.SelectCommand.Parameters.Add(_Proveedor)
            DBCommand.SelectCommand.Parameters.Add(_Linea)
            DBCommand.SelectCommand.Parameters.Add(_Grupo)
            DBCommand.SelectCommand.Parameters.Add(_SubGrupo)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ArticulosCCMaximo(ByVal Item As String, ByVal Proveedor As String, ByVal Linea As String, ByVal Grupo As String, ByVal SubGrupo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosCCMaximo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim _Linea As SqlParameter = New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim _Grupo As SqlParameter = New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim _SubGrupo As SqlParameter = New SqlParameter("@SubGrupo", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Item.Value = Item
            _Proveedor.Value = Proveedor
            _Linea.Value = Linea
            _Grupo.Value = Grupo
            _SubGrupo.Value = SubGrupo
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Item)
            DBCommand.SelectCommand.Parameters.Add(_Proveedor)
            DBCommand.SelectCommand.Parameters.Add(_Linea)
            DBCommand.SelectCommand.Parameters.Add(_Grupo)
            DBCommand.SelectCommand.Parameters.Add(_SubGrupo)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ArticulosCCExistencias(ByVal Item As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosCCExistencias", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Item.Value = Item
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Item)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ArticulosCCList1() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosCCList1", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function Kardex(ByVal Item As String, ByVal Proveedor As String, ByVal Linea As String, ByVal Grupo As String, ByVal SubGrupo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_InventarioKardex", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim _Linea As SqlParameter = New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim _Grupo As SqlParameter = New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim _SubGrupo As SqlParameter = New SqlParameter("@SubGrupo", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Item.Value = Item
            _Proveedor.Value = Proveedor
            _Linea.Value = Linea
            _Grupo.Value = Grupo
            _SubGrupo.Value = SubGrupo
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Item)
            DBCommand.SelectCommand.Parameters.Add(_Proveedor)
            DBCommand.SelectCommand.Parameters.Add(_Linea)
            DBCommand.SelectCommand.Parameters.Add(_Grupo)
            DBCommand.SelectCommand.Parameters.Add(_SubGrupo)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function SalidasList(ByVal Area As String, ByVal Fecha1 As String, ByVal Fecha2 As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_SalidasCCList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Area As New SqlParameter("@Area", SqlDbType.NVarChar)
            Dim _Fecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim _Fecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)

            _Area.Value = Area
            _Fecha1.Value = Fecha1
            _Fecha2.Value = Fecha2
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Area)
            DBCommand.SelectCommand.Parameters.Add(_Fecha1)
            DBCommand.SelectCommand.Parameters.Add(_Fecha2)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Tabla")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function AreasAcumulados(ByVal Area As String, ByVal Anio As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_AreasCCAcumulados", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Area As New SqlParameter("@Area", SqlDbType.NVarChar)
            Dim _Anio As New SqlParameter("@Anio", SqlDbType.Int)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)

            _Area.Value = Area
            _Anio.Value = Anio
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Area)
            DBCommand.SelectCommand.Parameters.Add(_Anio)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ArticuloAcumulado(ByVal Item As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosCCAcumulados", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Item.Value = Item
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Item)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function SalidasCCNumero() As Long
            Dim DBConn As SqlConnection
            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_SalidasCCNumero", DBConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim _Salida As SqlParameter = New SqlParameter("@Salida", SqlDbType.Decimal)
            _Salida.Direction = ParameterDirection.Output
            cmd.Parameters.Add(_Salida)

            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Empresa)

            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

            Return _Salida.Value

        End Function

        Public Function AreasList1() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_AreasConsumoList1", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function SalidasCCAddItem(ByVal Salida As String, ByVal Fecha As String, ByVal Area As String)

            Dim cmd As SqlCommand = New SqlCommand("_SalidasCCAdd", DBConnFacturas)
            cmd.CommandType = CommandType.StoredProcedure

            Dim _Salida As SqlParameter = New SqlParameter("@Salida", SqlDbType.NVarChar)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim _Area As SqlParameter = New SqlParameter("@Area", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Salida.Value = Salida
            _Fecha.Value = Fecha
            _Area.Value = Area
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Salida)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Area)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function SalidasCCDetallesAddItem(ByVal Salida As String, ByVal Item As String, ByVal Cantidad As String, _
                                         ByVal Costo As String)

            Dim cmd As SqlCommand = New SqlCommand("_SalidasCCDetallesAdd", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Salida As SqlParameter = New SqlParameter("@Salida", SqlDbType.NVarChar)
            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim _Cantidad As SqlParameter = New SqlParameter("@Cantidad", SqlDbType.Float)
            Dim _Costo As SqlParameter = New SqlParameter("@Costo", SqlDbType.Float)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Salida.Value = Salida
            _Item.Value = Item
            _Cantidad.Value = Cantidad
            _Costo.Value = Costo
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Salida)
            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Cantidad)
            cmd.Parameters.Add(_Costo)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function Dependientes(ByVal Codigo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ACDependientes", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Codigo As SqlParameter = New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Codigo.Value = Codigo
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Codigo)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function AreasDetalles(ByVal Codigo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_AreasConsumoDetalles", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Codigo As SqlParameter = New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Codigo.Value = Codigo
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Codigo)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function AreasEdit(ByVal Codigo As String, ByVal Nombre As String, ByVal Tipo As String, ByVal Responsable As String, ByVal Telefono As String, ByVal Fax As String, ByVal Direccion As String, ByVal Email As String, ByVal Departamento As String, ByVal Cuenta As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_AreasConsumoUpdate", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Codigo As SqlParameter = New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim _Nombre As SqlParameter = New SqlParameter("@Nombre", SqlDbType.NVarChar)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int)
            Dim _Responsable As SqlParameter = New SqlParameter("@Responsable", SqlDbType.NVarChar)
            Dim _Telefono As SqlParameter = New SqlParameter("@Telefono", SqlDbType.NVarChar)
            Dim _Fax As SqlParameter = New SqlParameter("@Fax", SqlDbType.NVarChar)
            Dim _Direccion As SqlParameter = New SqlParameter("@Direccion", SqlDbType.NVarChar)
            Dim _Email As SqlParameter = New SqlParameter("@Email", SqlDbType.NVarChar)
            Dim _Departamento As SqlParameter = New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim _Cuenta As SqlParameter = New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Codigo.Value = Codigo
            _Nombre.Value = Nombre
            _Tipo.Value = Tipo
            _Responsable.Value = Responsable
            _Telefono.Value = Telefono
            _Fax.Value = Fax
            _Direccion.Value = Direccion
            _Email.Value = Email
            _Departamento.Value = Departamento
            _Cuenta.Value = Cuenta
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Codigo)
            cmd.Parameters.Add(_Nombre)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Responsable)
            cmd.Parameters.Add(_Telefono)
            cmd.Parameters.Add(_Fax)
            cmd.Parameters.Add(_Direccion)
            cmd.Parameters.Add(_Email)
            cmd.Parameters.Add(_Departamento)
            cmd.Parameters.Add(_Cuenta)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()

        End Function

        Public Function AreasAddItem(ByVal Codigo As String, ByVal Nombre As String, ByVal Tipo As String, ByVal Responsable As String, ByVal Telefono As String, ByVal Fax As String, ByVal Direccion As String, ByVal Email As String, ByVal Departamento As String, ByVal Cuenta As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_AreasConsumoAdd", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Codigo As SqlParameter = New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim _Nombre As SqlParameter = New SqlParameter("@Nombre", SqlDbType.NVarChar)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int)
            Dim _Responsable As SqlParameter = New SqlParameter("@Responsable", SqlDbType.NVarChar)
            Dim _Telefono As SqlParameter = New SqlParameter("@Telefono", SqlDbType.NVarChar)
            Dim _Fax As SqlParameter = New SqlParameter("@Fax", SqlDbType.NVarChar)
            Dim _Direccion As SqlParameter = New SqlParameter("@Direccion", SqlDbType.NVarChar)
            Dim _Email As SqlParameter = New SqlParameter("@Email", SqlDbType.NVarChar)
            Dim _Departamento As SqlParameter = New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim _Cuenta As SqlParameter = New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Codigo.Value = Codigo
            _Nombre.Value = Nombre
            _Tipo.Value = Tipo
            _Responsable.Value = Responsable
            _Telefono.Value = Telefono
            _Fax.Value = Fax
            _Direccion.Value = Direccion
            _Email.Value = Email
            _Departamento.Value = Departamento
            _Cuenta.Value = Cuenta
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Codigo)
            cmd.Parameters.Add(_Nombre)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Responsable)
            cmd.Parameters.Add(_Telefono)
            cmd.Parameters.Add(_Fax)
            cmd.Parameters.Add(_Direccion)
            cmd.Parameters.Add(_Email)
            cmd.Parameters.Add(_Departamento)
            cmd.Parameters.Add(_Cuenta)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()

        End Function

        Public Function ACBuscarCodigo(ByVal Codigo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ACBuscarCodigo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Codigo As SqlParameter = New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Codigo.Value = Codigo
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Codigo)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function AreasList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_AreasConsumoList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ArticuloCCDelete(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_ArticulosCCDelete", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Codigo As SqlParameter = New SqlParameter("@Articulo", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Codigo.Value = Codigo
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Codigo)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()

        End Function

        Public Function ArticulosCCDetalles(ByVal Articulo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosCCDetalles", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Articulo As SqlParameter = New SqlParameter("@Articulo", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Articulo.Value = Articulo
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Articulo)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Tabla")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function ArticulosCCEdit(ByVal Codigo As String, ByVal Proveedor As String, _
            ByVal Descripcion As String, ByVal Linea As String, ByVal Grupo As String, _
            ByVal SubGrupo As String, ByVal Modelo As String, ByVal Unidad As String, _
            ByVal Presentacion As String, ByVal Ubicacion As String, ByVal Costo As String, _
            ByVal CostoPromedio As String, ByVal CostoUltimo As String, _
            ByVal StockMinimo As String, ByVal StockMaximo As String, ByVal Cuenta As String, _
            ByVal Exento As Boolean)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_ArticulosCCEdit", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Codigo As SqlParameter = New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Float)
            Dim _Descripcion As SqlParameter = New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Dim _Linea As SqlParameter = New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim _Grupo As SqlParameter = New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim _SubGrupo As SqlParameter = New SqlParameter("@SubGRupo", SqlDbType.NVarChar)
            Dim _Modelo As SqlParameter = New SqlParameter("@Modelo", SqlDbType.NVarChar)
            Dim _Unidad As SqlParameter = New SqlParameter("@Unidad", SqlDbType.NVarChar)
            Dim _Presentacion As SqlParameter = New SqlParameter("@Presentacion", SqlDbType.NVarChar)
            Dim _Ubicacion As SqlParameter = New SqlParameter("@Ubicacion", SqlDbType.NVarChar)
            Dim _Costo As SqlParameter = New SqlParameter("@Costo", SqlDbType.Float)
            'Dim _CostoPromedio As SqlParameter = New SqlParameter("@CostoPromedio", SqlDbType.Float)
            'Dim _CostoUltimo As SqlParameter = New SqlParameter("@CostoUltimo", SqlDbType.Float)
            Dim _StockMinimo As SqlParameter = New SqlParameter("@StockMinimo", SqlDbType.Float)
            Dim _StockMaximo As SqlParameter = New SqlParameter("@StockMaximo", SqlDbType.Float)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)
            Dim _Cuenta As SqlParameter = New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim _Exento As SqlParameter = New SqlParameter("@Exento", SqlDbType.Bit)

            _Codigo.Value = Codigo
            _Proveedor.Value = Proveedor
            _Descripcion.Value = Descripcion
            _Linea.Value = Linea
            _Grupo.Value = Grupo
            _SubGrupo.Value = SubGrupo
            _Modelo.Value = Modelo
            _Unidad.Value = Unidad
            _Presentacion.Value = Presentacion
            _Ubicacion.Value = Ubicacion
            _Costo.Value = Costo
            '_CostoPromedio.Value = CostoPromedio
            '_CostoUltimo.Value = CostoUltimo
            _StockMinimo.Value = StockMinimo
            _StockMaximo.Value = StockMaximo
            _Empresa.Value = EmpresaActual
            _Cuenta.Value = Cuenta
            _Exento.Value = Exento


            cmd.Parameters.Add(_Codigo)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_Descripcion)
            cmd.Parameters.Add(_Linea)
            cmd.Parameters.Add(_Grupo)
            cmd.Parameters.Add(_SubGrupo)
            cmd.Parameters.Add(_Modelo)
            cmd.Parameters.Add(_Unidad)
            cmd.Parameters.Add(_Presentacion)
            cmd.Parameters.Add(_Ubicacion)
            cmd.Parameters.Add(_Costo)
            cmd.Parameters.Add(_StockMinimo)
            cmd.Parameters.Add(_StockMaximo)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Cuenta)
            cmd.Parameters.Add(_Exento)

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()

        End Function

        Public Function ArticulosCCList(ByVal Letra As String, ByVal Proveedor As String, ByVal Linea As String, ByVal Grupo As String, ByVal SubGrupo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosCCList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Letra As SqlParameter = New SqlParameter("@Letra", SqlDbType.NVarChar)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim _Linea As SqlParameter = New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim _Grupo As SqlParameter = New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim _SubGrupo As SqlParameter = New SqlParameter("@SubGrupo", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Letra.Value = Letra
            _Proveedor.Value = Proveedor
            _Linea.Value = Linea
            _Grupo.Value = Grupo
            _SubGrupo.Value = SubGrupo
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Letra)
            DBCommand.SelectCommand.Parameters.Add(_Proveedor)
            DBCommand.SelectCommand.Parameters.Add(_Linea)
            DBCommand.SelectCommand.Parameters.Add(_Grupo)
            DBCommand.SelectCommand.Parameters.Add(_SubGrupo)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ArticulosCCList() As DataTable
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosCC_Lista", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")
            DBConn.Close()
            Return dsFicha.Tables(0)

        End Function


        '**********************************************************************
        'Creado by Jhonny Arauz 
        'Obtener Lista de Productos de Inventario
        Public Function ArticulosCCInvent() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArticulosCCInvent", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function ArticulosCCAddItem(ByVal Codigo As String, ByVal Proveedor As String, _
            ByVal Descripcion As String, ByVal Linea As String, ByVal Grupo As String, _
            ByVal SubGrupo As String, ByVal Modelo As String, ByVal Unidad As String, _
            ByVal Presentacion As String, ByVal Ubicacion As String, ByVal Costo As String, _
            ByVal CostoPromedio As String, ByVal CostoUltimo As String, ByVal StockMinimo As String, _
            ByVal StockMaximo As String, ByVal Cuenta As String, ByVal Exento As Boolean)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_ArticulosCCAdd", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Codigo As SqlParameter = New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.Float)
            Dim _Descripcion As SqlParameter = New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Dim _Linea As SqlParameter = New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim _Grupo As SqlParameter = New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim _SubGrupo As SqlParameter = New SqlParameter("@SubGRupo", SqlDbType.NVarChar)
            Dim _Modelo As SqlParameter = New SqlParameter("@Modelo", SqlDbType.NVarChar)
            Dim _Unidad As SqlParameter = New SqlParameter("@Unidad", SqlDbType.NVarChar)
            Dim _Presentacion As SqlParameter = New SqlParameter("@Presentacion", SqlDbType.NVarChar)
            Dim _Ubicacion As SqlParameter = New SqlParameter("@Ubicacion", SqlDbType.NVarChar)
            Dim _Costo As SqlParameter = New SqlParameter("@Costo", SqlDbType.Float)
            'Dim _CostoPromedio As SqlParameter = New SqlParameter("@CostoPromedio", SqlDbType.Float)
            'Dim _CostoUltimo As SqlParameter = New SqlParameter("@CostoUltimo", SqlDbType.Float)
            Dim _StockMinimo As SqlParameter = New SqlParameter("@StockMinimo", SqlDbType.Float)
            Dim _StockMaximo As SqlParameter = New SqlParameter("@StockMaximo", SqlDbType.Float)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)
            Dim _Cuenta As SqlParameter = New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim _Exento As SqlParameter = New SqlParameter("@Exento", SqlDbType.Bit)

            _Codigo.Value = Codigo
            _Proveedor.Value = Proveedor
            _Descripcion.Value = Descripcion
            _Linea.Value = Linea
            _Grupo.Value = Grupo
            _SubGrupo.Value = SubGrupo
            _Modelo.Value = Modelo
            _Unidad.Value = Unidad
            _Presentacion.Value = Presentacion
            _Ubicacion.Value = Ubicacion
            _Costo.Value = Costo
            '_CostoPromedio.Value = CostoPromedio
            '_CostoUltimo.Value = CostoUltimo
            _StockMinimo.Value = StockMinimo
            _StockMaximo.Value = StockMaximo
            _Empresa.Value = EmpresaActual
            _Cuenta.Value = Cuenta
            _Exento.Value = Exento


            cmd.Parameters.Add(_Codigo)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_Descripcion)
            cmd.Parameters.Add(_Linea)
            cmd.Parameters.Add(_Grupo)
            cmd.Parameters.Add(_SubGrupo)
            cmd.Parameters.Add(_Modelo)
            cmd.Parameters.Add(_Unidad)
            cmd.Parameters.Add(_Presentacion)
            cmd.Parameters.Add(_Ubicacion)
            cmd.Parameters.Add(_Costo)
            cmd.Parameters.Add(_StockMinimo)
            cmd.Parameters.Add(_StockMaximo)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Cuenta)
            cmd.Parameters.Add(_Exento)


            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()

        End Function

        Public Function SubGrupos(ByVal Grupo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_SubGruposCC", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Grupo As SqlParameter = New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Grupo.Value = Grupo
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Grupo)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function Grupos(ByVal Linea As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GruposCC", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Linea As SqlParameter = New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Linea.Value = IsNull(Linea, "")
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Linea)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function Lineas() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LineasCC", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function Edit(ByVal Codigo As String, ByVal Nombre As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_GruposCCUpdate", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Codigo As SqlParameter = New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim _Nombre As SqlParameter = New SqlParameter("@Nombre", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Codigo.Value = Codigo
            _Nombre.Value = Nombre
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Codigo)
            cmd.Parameters.Add(_Nombre)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()

        End Function

        Public Function AddItem(ByVal Codigo As String, ByVal Nombre As String, ByVal Nivel As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_GruposCCAdd", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Codigo As SqlParameter = New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim _Nombre As SqlParameter = New SqlParameter("@Nombre", SqlDbType.NVarChar)
            Dim _Nivel As SqlParameter = New SqlParameter("@Nivel", SqlDbType.Int)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Codigo.Value = Codigo
            _Nombre.Value = Nombre
            _Nivel.Value = Nivel
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Codigo)
            cmd.Parameters.Add(_Nombre)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Nivel)

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()

        End Function

        Public Function List() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GruposCCList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function Delete(ByVal Codigo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM GruposCC WHERE Grupo_ID = '" & Codigo & "' AND Empresa_ID = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()

            DBConn.Close()

        End Function

        Public Function NivelSuperior(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("Select Grupo_ID AS Código, Grupo_Nombre AS Nombre From GruposCC WHERE Grupo_ID ='" & Filtro & "' AND Grupo_Nivel <> 3 AND Empresa_ID = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListCodigo(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("Select Grupo_ID AS Código, Grupo_Nombre AS Nombre From GruposCC WHERE Grupo_ID ='" & Filtro & "' AND Empresa_ID = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function Detalles(ByVal Codigo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GruposCCDetalles", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Codigo As SqlParameter = New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Codigo.Value = Codigo
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Codigo)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Sub ArticulosCCUpdate(ByVal Codigo As String, ByVal Nombre As String, ByVal proveedor As Integer, ByVal Costo As Decimal, ByVal IVA As Integer, ByVal Cuenta As String)
            '-------------------------------
            'Funcion para actualizar los valores de la tabla de Productos en Inventario
            'Create By Jhonny Arauz

            Dim update As String = "UPDATE ArticulosCC Set Articulo_ID = '" & Codigo & "', Articulo_Descripcion = '" & Nombre & "', Proveedor_ID = " & proveedor & "," _
            & " Articulo_Costo = " & Costo & ", Exento = " & IVA & ", Cuenta = '" & Cuenta & "' WHERE (Articulo_ID = '" & Codigo & "' AND Empresa_ID = " & EmpresaActual & ")"

            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = update

            cmd.Connection = DBConn 'Se asigna conexion al comando y se abre conexion 
            DBConn.Open()

            cmd.ExecuteNonQuery()

            DBConn.Close()
        End Sub
    End Class
End Namespace
