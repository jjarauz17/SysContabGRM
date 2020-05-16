Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class ComisionDetails
        Public Codigo As String
        Public Nombre As String

    End Class

    Public Class ComisionDB

        Public Function GetComisionLineaVendedor(ByVal Vendedor As String, ByVal Linea As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ComisionLineaVendedor", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pVendedor As New SqlParameter("@Vendedor", SqlDbType.NVarChar)
            Dim pLinea As New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pVendedor.Value = Vendedor
            pLinea.Value = Linea
            pTipo.Value = Tipo
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pVendedor)
            DBCommand.SelectCommand.Parameters.Add(pLinea)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Comisiones")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetComisionItemVendedor(ByVal Vendedor As String, ByVal Item As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ComisionItemVendedor", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pVendedor As New SqlParameter("@Vendedor", SqlDbType.NVarChar)
            Dim pItem As New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pVendedor.Value = Vendedor
            pItem.Value = Item
            pTipo.Value = Tipo
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pVendedor)
            DBCommand.SelectCommand.Parameters.Add(pItem)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Comisiones")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListReporte(ByVal Vendedor As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListComisionesReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Vendedor", SqlDbType.Int)
            Dim pIdent1 As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Vendedor
            pIdent1.Value = Tipo
            pIdent2.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "CARGOS")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GetDetails(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsZonas As New DataSet()
            Dim Details As New ComisionDetails()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM Zonas WHERE Codigo = " & Codigo, DBConn)

            DBCommand.Fill(dsZonas, "Zonas")

            If dsZonas.Tables("Zonas").Rows.Count = 1 Then
                Details.Codigo = dsZonas.Tables("Zonas").Rows(0).Item("Codigo")
                Details.Nombre = dsZonas.Tables("Zonas").Rows(0).Item("Nombre")

            End If

            Return Details

        End Function


        Public Function GetList(ByVal Vendedor As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT COMISIONES.CODIGO AS CODIGO, ARTICULOS.NOMBRE AS NOMBRE, COMISION FROM COMISIONES, ARTICULOS WHERE COMISIONES.CODIGO_ARTICULO = ARTICULOS.CODIGO_ARTICULO AND COMISIONES.EMPRESA = ARTICULOS.EMPRESA AND COMISIONES.Tipo = ARTICULOS.Tipo AND CODIGO_VENDEDOR = '" & Vendedor & "' AND COMISIONES.Tipo = '" & Tipo & "' AND COMISIONES.EMPRESA = '" & EmpresaActual & "' ORDER BY CODIGO", DBConn)
            DBCommand.Fill(dsFicha, "COMISIONES")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListNuevo(ByVal Codigo_Vendedor As String, ByVal Codigo_Articulo As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM COMISIONES WHERE CODIGO_VENDEDOR = '" & Codigo_Vendedor & "' AND CODIGO_ARTICULO = '" & Codigo_Articulo & "' AND COMISIONES.Tipo = '" & Tipo & "' AND EMPRESA = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "COMISIONES")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            ' Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo, Nombre FROM Zonas WHERE Nombre Like '%" & Filtro & "%'", DBConn)
            DBCommand.Fill(dsFicha, "Zonas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListNombre(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            ' Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo, Nombre FROM Zonas WHERE Nombre = '" & Filtro & "'", DBConn)
            DBCommand.Fill(dsFicha, "Zonas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function AddItem(ByVal Codigo_Vendedor As String, ByVal Codigo_Articulo As String, ByVal Comision As String, ByVal Tipo As String)


            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO COMISIONES(Codigo_Vendedor, Codigo_Articulo, Comision, Tipo, Empresa) " & _
                              "Values(" & "'" & Codigo_Vendedor & "','" & Codigo_Articulo & "','" & Comision & "','" & Tipo & "','" & EmpresaActual & "')"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function Update(ByVal Codigo As String, ByVal Nombre As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE Zonas SET Nombre = '" & Nombre & "' " & "WHERE Codigo = '" & Codigo & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function Delete(ByVal Codigo As String, ByVal Tipo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM Comisiones WHERE Codigo ='" & Codigo & "' AND Tipo = '" & Tipo & "' AND Empresa = " & EmpresaActual

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()

            DBConn.Close()

        End Function

    End Class

End Namespace