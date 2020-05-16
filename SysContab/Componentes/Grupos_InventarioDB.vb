Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class Grupos_InventarioDetails
        Public Codigo As String
        Public Nombre As String
        Public Nivel As String
        Public Total As String
        Public Tipo As String
        Public Retencion As Double
        Public MontoRetencion As Double
        Public Utilidad As Double
        Public Utilidad_Minima As Double
        Public Utilidad_Maxima As Double
        Public Descuento_Ventas As Double
        Public Descuento_Comercial As Double
    End Class

    Public Class Grupos_InventarioDB

        'Public Function SubGrupos(ByVal Grupo As String) As DataSet
        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet()

        '    Dim conexion As New VB.SysContab.Rutinas()
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_SubGrupos", DBConn)

        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    Dim _Grupo As SqlParameter = New SqlParameter("@Grupo", SqlDbType.NVarChar)
        '    Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

        '    _Grupo.Value = Grupo
        '    _Empresa.Value = EmpresaActual

        '    DBCommand.SelectCommand.Parameters.Add(_Grupo)
        '    DBCommand.SelectCommand.Parameters.Add(_Empresa)

        '    DBCommand.Fill(dsFicha, "GruposCC")

        '    DBConn.Close()

        '    Return dsFicha

        'End Function
        Public Shared Function SubGrupos(ByVal Grupo As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_SubGruposTipo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Grupo As SqlParameter = New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar)

            _Grupo.Value = Grupo
            _Empresa.Value = EmpresaActual
            _Tipo.Value = Tipo

            DBCommand.SelectCommand.Parameters.Add(_Grupo)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)
            DBCommand.SelectCommand.Parameters.Add(_Tipo)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        'Public Function S_SubGrupos(ByVal Grupo As String) As DataSet
        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet

        '    Dim conexion As New VB.SysContab.Rutinas
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_S_SubGrupos", DBConn)

        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    Dim _Grupo As SqlParameter = New SqlParameter("@Grupo", SqlDbType.NVarChar)
        '    Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

        '    _Grupo.Value = Grupo
        '    _Empresa.Value = EmpresaActual

        '    DBCommand.SelectCommand.Parameters.Add(_Grupo)
        '    DBCommand.SelectCommand.Parameters.Add(_Empresa)


        '    DBCommand.Fill(dsFicha, "GruposCC")

        '    DBConn.Close()

        '    Return dsFicha

        'End Function

        Public Function S_SubGrupos(ByVal Grupo As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_S_SubGruposTipo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Grupo As SqlParameter = New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar)

            _Grupo.Value = Grupo
            _Empresa.Value = EmpresaActual
            _Tipo.Value = Tipo

            DBCommand.SelectCommand.Parameters.Add(_Grupo)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)
            DBCommand.SelectCommand.Parameters.Add(_Tipo)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        'Public Function Grupos(ByVal Linea As String) As DataSet
        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet

        '    Dim conexion As New VB.SysContab.Rutinas
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_Grupos", DBConn)

        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    Dim _Linea As SqlParameter = New SqlParameter("@Linea", SqlDbType.NVarChar)
        '    Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

        '    _Linea.Value = Linea
        '    _Empresa.Value = EmpresaActual

        '    DBCommand.SelectCommand.Parameters.Add(_Linea)
        '    DBCommand.SelectCommand.Parameters.Add(_Empresa)

        '    DBCommand.Fill(dsFicha, "GruposCC")

        '    DBConn.Close()

        '    Return dsFicha

        'End Function

        Public Shared Function Grupos(ByVal Linea As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Grupos_Tipo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Linea As SqlParameter = New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar)

            _Linea.Value = IsNull(Linea, "")
            _Empresa.Value = EmpresaActual
            _Tipo.Value = Tipo

            DBCommand.SelectCommand.Parameters.Add(_Linea)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)
            DBCommand.SelectCommand.Parameters.Add(_Tipo)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha

        End Function

        'Public Function Lineas() As DataSet
        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet

        '    Dim conexion As New VB.SysContab.Rutinas
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_Lineas", DBConn)

        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

        '    _Empresa.Value = EmpresaActual

        '    DBCommand.SelectCommand.Parameters.Add(_Empresa)

        '    DBCommand.Fill(dsFicha, "GruposCC")

        '    DBConn.Close()

        '    Return dsFicha

        'End Function
        Public Shared Function Lineas(ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LineasTipo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar, 1)

            _Empresa.Value = EmpresaActual
            _Tipo.Value = Tipo

            DBCommand.SelectCommand.Parameters.Add(_Empresa)
            DBCommand.SelectCommand.Parameters.Add(_Tipo)

            DBCommand.Fill(dsFicha, "GruposCC")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function LineasServiciosList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LineasServiciosList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            'pNombre.Value = Nombre
            pEmpresa.Value = EmpresaActual

            'DBCommand.SelectCommand.Parameters.Add(pNombre)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Try
                DBCommand.Fill(dsFicha, "Grupos_Inventario")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ListGruposxLineasProductos(ByVal Linea As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GruposxLineaProductosList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pLinea As New SqlParameter("@Linea", SqlDbType.NVarChar)
            'Dim pNombre As New SqlParameter("@Nombre", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pLinea.Value = Linea
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pLinea)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Try
                DBCommand.Fill(dsFicha, "Grupos_Inventario")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ListLineasProductos(ByVal Nombre As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LineasProductosList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pNombre As New SqlParameter("@Nombre", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pNombre.Value = Nombre
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pNombre)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Try
                DBCommand.Fill(dsFicha, "Grupos_Inventario")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListComisionLinea(ByVal Vendedor As String, ByVal Linea As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListVendedorLineas", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pVendedor As New SqlParameter("@Vendedor", SqlDbType.NVarChar)
            Dim pLinea As New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pVendedor.Value = Vendedor
            pLinea.Value = Linea
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pVendedor)
            DBCommand.SelectCommand.Parameters.Add(pLinea)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Try
                DBCommand.Fill(dsFicha, "VENDEDOR_LINEA")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try


            DBConn.Close()

            Return dsFicha

            'If dsFicha.Tables("VENDEDOR_LINEA").Rows.Count = 0 Then
            '    Return False
            'Else
            '    Return True

            'End If

        End Function

        Public Function DeleteVendedorLinea(ByVal Vendedor As String, ByVal Linea As String) As String

            Dim DBConn As SqlConnection
            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())
            'Dim Conn As New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As New SqlCommand("_DeleteVendedorLinea", DBConn)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add("@Vendedor", Vendedor)
            cmd.Parameters.Add("@Linea", Linea)
            cmd.Parameters.Add("@Empresa", EmpresaActual)
            Try
                DBConn.Open()
                cmd.ExecuteNonQuery()
                DBConn.Close()
                Return 1

            Catch
                Return String.Empty
            End Try

        End Function

        Public Shared Sub DeleteLineasVendedor(Vendedor As Integer)
            GuardaDatos("JAR_DeleteVendedorLineas " & Vendedor & "," & EmpresaActual)
        End Sub

        Public Function GetListVendedorLineas(ByVal Vendedor As String, ByVal Linea As String) As Boolean
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListVendedorLineas", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pVendedor As New SqlParameter("@Vendedor", SqlDbType.NVarChar)
            Dim pLinea As New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pVendedor.Value = Vendedor
            pLinea.Value = Linea
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pVendedor)
            DBCommand.SelectCommand.Parameters.Add(pLinea)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Try
                DBCommand.Fill(dsFicha, "VENDEDOR_LINEA")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try


            DBConn.Close()

            'Return dsFicha
            If dsFicha.Tables("VENDEDOR_LINEA").Rows.Count = 0 Then
                Return False
            Else
                Return True

            End If

        End Function

        Public Function AddLineaVendedor(ByVal Vendedor As String, ByVal Linea As String, ByVal Comision As String, ByVal Tipo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO VENDEDOR_LINEA(Vendedor, Linea, Comision, Tipo, Empresa) " & _
                        "Values(" & "'" & Vendedor & "','" & Linea & "','" & Comision & "','" & Tipo & "','" & EmpresaActual & "')"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function UpdateComision(ByVal Vendedor As String, ByVal Linea As String, ByVal Comision As String, ByVal Tipo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE VENDEDOR_LINEA SET Comision = " & Comision & " WHERE Vendedor_Linea.Vendedor = '" & Vendedor & "' AND Vendedor_Linea.Linea = '" & Linea & "' AND Tipo = '" & Tipo & "' AND Empresa = '" & EmpresaActual & "'"

            'WHERE Vendedor_Linea.Vendedor = @Vendedor
            'AND Vendedor_Linea.Linea = @Linea
            'AND Vendedor_Linea.Empresa = @Empresa

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListGruposInventarioReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Tipo", SqlDbType.NVarChar)

            pIdent.Value = Filtro
            pIdent2.Value = Empresa
            pIdent3.Value = Tipo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsFicha, "Grupos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetDetails(ByVal Codigo As String, ByVal Tipo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsGrupo As New DataSet
            Dim Details As New Grupos_InventarioDetails

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM Grupos_Inventario WHERE CODIGO_GRUPO = '" & Codigo & "' AND Tipo = '" & Tipo & "' AND Empresa ='" & EmpresaActual & "'", DBConn)

            DBCommand.Fill(dsGrupo, "Grupos_Inventario")

            If dsGrupo.Tables("Grupos_Inventario").Rows.Count = 1 Then
                Details.Codigo = dsGrupo.Tables("Grupos_Inventario").Rows(0).Item("CODIGO_GRUPO")
                Details.Nombre = dsGrupo.Tables("Grupos_Inventario").Rows(0).Item("Nombre")

                'Details.Nivel = dsGrupo.Tables("Grupos_Inventario").Rows(0).Item("Nivel")
                'If dsGrupo.Tables("Grupos").Rows(0).Item("Total") Is DBNull.Value Then
                '    Details.Total = ""
                'Else
                '    Details.Total = dsGrupo.Tables("Grupos").Rows(0).Item("Total")
                'End If

                Details.Tipo = dsGrupo.Tables("Grupos_Inventario").Rows(0).Item("Tipo")
                Details.Retencion = dsGrupo.Tables("Grupos_Inventario").Rows(0).Item("Retencion")
                Details.MontoRetencion = dsGrupo.Tables("Grupos_Inventario").Rows(0).Item("MontoRetencion")

                Details.Utilidad = dsGrupo.Tables("Grupos_Inventario").Rows(0).Item("Utilidad")
                Details.Utilidad_Minima = dsGrupo.Tables("Grupos_Inventario").Rows(0).Item("Utilidad_Minima")
                Details.Utilidad_Maxima = dsGrupo.Tables("Grupos_Inventario").Rows(0).Item("Utilidad_Maxima")
                Details.Descuento_Ventas = dsGrupo.Tables("Grupos_Inventario").Rows(0).Item("Descuento_Ventas")
                Details.Descuento_Comercial = dsGrupo.Tables("Grupos_Inventario").Rows(0).Item("Descuento_Comercial")
            End If

            Return Details
        End Function

        Public Shared Function GetList(ByVal Tipo As String) As DataTable


            Return ObtieneDatos("JAR_GetGruposInventarios", Tipo, EmpresaActual)

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet
            'Dim cd As String

            'Dim conexion As New VB.SysContab.Rutinas
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("Select CODIGO_GRUPO AS Código, Nombre, CASE Nivel WHEN 1 THEN 'Linea' WHEN 2 THEN 'Grupo' WHEN 3 THEN 'Sub Grupo' ELSE 'S-Sub Grupo' END AS Tipo From GRUPOS_INVENTARIO WHERE Tipo = '" & Tipo & "' AND Empresa = '" & EmpresaActual & "' ORDER BY Codigo_Grupo", DBConn)
            'DBCommand.Fill(dsFicha, "GRUPOS_INVENTARIO")

            'DBConn.Close()

            'Return dsFicha

        End Function

        Public Function GetListBuscar(ByVal Tipo As String) As DataTable

            Return ObtieneDatos("JAR_GetGruposInventariosAgregar", Tipo, EmpresaActual)

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet
            'Dim cd As String

            'Dim conexion As New VB.SysContab.Rutinas
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ''cd = "Select CODIGO_GRUPO, NOMBRE From Grupos_Inventario WHERE Tipo = '" & Tipo & "' AND Nombre Like '%" & Filtro & "%' ORDER BY Codigo_Grupo"

            'DBCommand = New SqlDataAdapter("Select CODIGO_GRUPO AS Código, Nombre, CASE Nivel WHEN 1 THEN 'Linea' WHEN 2 THEN 'Grupo' ELSE 'Sub Grupo' END AS Tipo From GRUPOS_INVENTARIO WHERE Tipo = '" & Tipo & "' AND Nombre Like '%" & Filtro & "%' AND Empresa = '" & EmpresaActual & "' ORDER BY CODIGO_GRUPO", DBConn)
            'DBCommand.Fill(dsFicha, "GRUPOS_INVENTARIO")

            'DBConn.Close()

            'Return dsFicha

        End Function

        Public Function GetListBuscarCombo(ByVal Filtro As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("Select CODIGO_GRUPO, NOMBRE From GRUPOS_INVENTARIO WHERE Tipo = '" & Tipo & "' AND Nombre Like '" & Filtro & "%' AND Empresa = '" & EmpresaActual & "' ORDER BY NOMBRE", DBConn)
            DBCommand.Fill(dsFicha, "GRUPOS_INVENTARIO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListCodigo(ByVal Filtro As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'Try
            'DBConn = New OleDbConnection("server=HP18599821974;" _
            '                        & "Initial Catalog=Inscripcion;" _
            '                        & "User Id=sa;" _
            '                        & "Password=enter;")

            DBCommand = New SqlDataAdapter("Select CODIGO_GRUPO, Nombre From Grupos_Inventario WHERE Tipo = '" & Tipo & "' AND CODIGO_GRUPO ='" & Filtro & "' AND Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "Grupos_Inventario")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function Delete(ByVal Codigo As String, ByVal Tipo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM Grupos_Inventario WHERE CODIGO_GRUPO = '" & Codigo & "' AND Tipo = '" & Tipo & "' AND Empresa = '" & EmpresaActual & "'"

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

        Public Function AddItem(ByVal Codigo_Grupo As String, ByVal Nombre As String, ByVal Tipo As String, ByVal Nivel As String, _
                                Optional ByVal Retencion As Double = 0.0, _
                                Optional ByVal MontoRetencion As Double = 0.0, _
                                Optional Utilidad As Double = 0.0, _
                                Optional DescVentas As Double = 0.0, _
                                Optional DescGerenecia As Double = 0.0, _
                                Optional UtilidadMin As Double = 0.0, _
                                Optional UtilidadMax As Double = 0.0)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Grupos_Inventario(CODIGO_GRUPO, NOMBRE, TIPO, NIVEL, EMPRESA,Retencion,MontoRetencion,Utilidad,Descuento_Ventas,Descuento_Comercial, Utilidad_Minima, Utilidad_Maxima) " & _
                                "Values(" & "'" & Codigo_Grupo & "','" & Nombre & "','" & Tipo & "','" & Nivel & "','" & EmpresaActual & "'," & Retencion & "," & MontoRetencion & "," & Utilidad & "," & DescVentas & "," & DescGerenecia & "," & UtilidadMin & "," & UtilidadMax & ")"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function Update(ByVal Codigo As String, ByVal Nombre As String, ByVal Tipo As String, _
                               Optional ByVal Retencion As Double = 0.0, _
                               Optional ByVal MonotRetencion As Double = 0.0, _
                               Optional Utilidad As Double = 0.0, _
                                Optional DescVentas As Double = 0.0, _
                                Optional DescGerenecia As Double = 0.0, _
                                Optional UtilidadMin As Double = 0.0, _
                                Optional UtilidadMax As Double = 0.0)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE Grupos_Inventario SET Nombre = '" & Nombre & "', Retencion = " & Retencion & ", MontoRetencion = " & MonotRetencion & ", Utilidad = " & Utilidad & " , Descuento_Ventas = " & DescVentas & ", Descuento_Comercial = " & DescGerenecia & ", Utilidad_Minima = " & UtilidadMin & ", Utilidad_Maxima = " & UtilidadMax & "  WHERE CODIGO_GRUPO = '" & Codigo & "' AND Tipo = '" & Tipo & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()
        End Function

    End Class

End Namespace
