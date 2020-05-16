Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class CargosDetails
        Public Codigo As String
        Public Nombre As String

    End Class

    Public Class CargosDB

        Public Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCargosReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = Empresa
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "CARGOS")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GetDetails(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsCargos As New DataSet()
            Dim Details As New CargosDetails()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCargosDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)


            DBCommand.Fill(dsCargos, "CARGOS")

            If dsCargos.Tables("CARGOS").Rows.Count = 1 Then
                Details.Codigo = dsCargos.Tables("CARGOS").Rows(0).Item("Codigo")
                Details.Nombre = dsCargos.Tables("CARGOS").Rows(0).Item("Nombre")
            End If

            Return Details

        End Function

        Public Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCargos", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Cargos")

            DBConn.Close()
            Return dsFicha

        End Function

        Public Function GetListNuevo() As String
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCargosNuevo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Cargos")

            DBConn.Close()

            Return Trim(Str(dsFicha.Tables("Cargos").Rows(0).Item("Codigo") + 1))

        End Function

        Public Function GetListBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCargosBuscar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Cargos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscarCombo(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCargosBuscarCombo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Cargos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListNombre(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCargosBuscar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Cargos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function AddItem(ByVal Codigo As String, ByVal Nombre As String) As Integer

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CargosAdd", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Nombre", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Nombre

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
                Return -1
            End Try
            Return 0

        End Function

        Public Function Update(ByVal Codigo As String, ByVal Nombre As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CargosUpdate", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Descripcion", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Nombre

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function

        Public Function Delete(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CargosDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.NVarChar)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual


            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function

        Public Function GenReporte(ByVal Grupo As String, ByVal Mayor As String, ByVal Subcuenta As String, _
        ByVal Auxiliar As String, ByVal Saldo As Integer, ByVal Mes As Integer, _
        ByVal Moneda As Integer, ByVal Tipocambio As Integer, ByVal Ordenar As Integer) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCatalogoGeneradorReportes", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Grupo As New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim _Mayor As New SqlParameter("@Mayor", SqlDbType.NVarChar)
            Dim _Subcuenta As New SqlParameter("@Subcuenta", SqlDbType.NVarChar)
            Dim _Auxiliar As New SqlParameter("@Auxiliar", SqlDbType.NVarChar)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim _Saldo As New SqlParameter("@Saldo", SqlDbType.Int)
            Dim _Mes As New SqlParameter("@Mes", SqlDbType.Int)
            Dim _Moneda As New SqlParameter("@Moneda", SqlDbType.Int)
            Dim _Tipocambio As New SqlParameter("@Tipocambio", SqlDbType.Float)
            Dim _Ordenar As New SqlParameter("@Ordenar", SqlDbType.Int)

            _Grupo.Value = Grupo
            _Mayor.Value = Mayor
            _Subcuenta.Value = Subcuenta
            _Auxiliar.Value = Auxiliar
            _Empresa.Value = EmpresaActual
            _Saldo.Value = Saldo
            _Mes.Value = Mes
            _Moneda.Value = Moneda
            _Tipocambio.Value = Tipocambio
            _Ordenar.Value = Ordenar

            DBCommand.SelectCommand.Parameters.Add(_Grupo)
            DBCommand.SelectCommand.Parameters.Add(_Mayor)
            DBCommand.SelectCommand.Parameters.Add(_Subcuenta)
            DBCommand.SelectCommand.Parameters.Add(_Auxiliar)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)
            DBCommand.SelectCommand.Parameters.Add(_Saldo)
            DBCommand.SelectCommand.Parameters.Add(_Mes)
            DBCommand.SelectCommand.Parameters.Add(_Moneda)
            DBCommand.SelectCommand.Parameters.Add(_Tipocambio)
            DBCommand.SelectCommand.Parameters.Add(_Ordenar)

            DBCommand.Fill(dsFicha, "CATALOGO")
            DBConn.Close()
            DBConn.Dispose()

            Return dsFicha

        End Function

    End Class

End Namespace
