Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class Comisiones_ServiciosDetails
        Public Codigo As String
        Public Nombre As String

    End Class

    Public Class Comisiones_ServiciosDB

        Public Function GetListReporte(ByVal Vendedor As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListComisionesServiciosReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Vendedor", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Vendedor
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "CARGOS")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GetDetails(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsZonas As New DataSet()
            Dim Details As New Comisiones_ServiciosDetails()

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


        Public Function GetList(ByVal Vendedor As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT COMISIONES_SERVICIOS.CODIGO AS CODIGO, SERVICIOS.NOMBRE AS NOMBRE, COMISION FROM COMISIONES_SERVICIOS, SERVICIOS WHERE COMISIONES_SERVICIOS.CODIGO_SERVICIO = SERVICIOS.CODIGO_SERVICIO AND CODIGO_VENDEDOR = '" & Vendedor & "' AND COMISIONES_SERVICIOS.EMPRESA = '" & EmpresaActual & "' ORDER BY CODIGO", DBConn)
            DBCommand.Fill(dsFicha, "COMISIONES_SERVICIOS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListNuevo(ByVal Codigo_Vendedor As String, ByVal Codigo_Servicio As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM COMISIONES_SERVICIOS WHERE CODIGO_VENDEDOR = '" & Codigo_Vendedor & "' AND CODIGO_SERVICIO = '" & Codigo_Servicio & "' AND EMPRESA = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "COMISIONES_SERVICIOS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

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
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo, Nombre FROM Zonas WHERE Nombre = '" & Filtro & "'", DBConn)
            DBCommand.Fill(dsFicha, "Zonas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function AddItem(ByVal Codigo_Vendedor As String, ByVal Codigo_Servicio As String, ByVal Comision As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO COMISIONES_SERVICIOS(Codigo_Vendedor, Codigo_Servicio, Comision, Empresa) " & _
                        "Values(" & "'" & Codigo_Vendedor & "','" & Codigo_Servicio & "','" & Comision & "','" & EmpresaActual & "')"

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

        Public Function Delete(ByVal Codigo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM Comisiones_Servicios WHERE Codigo ='" & Codigo & "'"

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

    End Class

End Namespace
