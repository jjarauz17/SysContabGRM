Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class ZonasDetails
        Public Codigo As String
        Public Nombre As String

    End Class

    Public Class ZonasDB

        Public Function ZonasList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ZonasList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Zonas")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GetListReporte(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListZonasReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Zonas")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GetDetails(ByVal Codigo As String) As ZonasDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsZonas As New DataSet()
            Dim Details As New ZonasDetails()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM Zonas WHERE Codigo = " & Codigo & " AND Empresa = '" & EmpresaActual & "'", DBConn)

            DBCommand.Fill(dsZonas, "Zonas")

            If dsZonas.Tables("Zonas").Rows.Count = 1 Then
                Details.Codigo = dsZonas.Tables("Zonas").Rows(0).Item("Codigo")
                Details.Nombre = dsZonas.Tables("Zonas").Rows(0).Item("Nombre")

            End If

            Return Details
        End Function


        Public Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo, Nombre as [Nombre] FROM Zonas WHERE Empresa ='" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "Zonas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListNuevo() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM Zonas ORDER BY Codigo DESC", DBConn)
            DBCommand.Fill(dsFicha, "Zonas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            'Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo, Nombre FROM Zonas WHERE Nombre Like '%" & Filtro & "%' AND Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "Zonas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscarCombo() As DataTable

            Return ObtieneDatos("sp_sel_ZONASFill", EmpresaActual)

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()
            ''Dim cd As String

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ''DBCommand = New SqlDataAdapter("SELECT Codigo, Nombre FROM Zonas WHERE Nombre Like '" & Filtro & "%' AND Empresa = '" & EmpresaActual & "' ORDER BY NOMBRE", DBConn)
            'DBCommand = New SqlDataAdapter("SELECT 0 AS Codigo, NULL AS Nombre, 1 AS Orden " & _
            '                               "UNION " & _
            '                               "SELECT Codigo, Nombre, 2 AS Orden " & _
            '                               "FROM Zonas " & _
            '                               "WHERE Empresa = " & EmpresaActual & _
            '                               " ORDER BY Orden, NOMBRE", DBConn)
            'DBCommand.Fill(dsFicha, "Zonas")

            'DBConn.Close()

            'Return dsFicha

        End Function

        Public Function GetListNombre(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            'Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo, Nombre FROM Zonas WHERE Nombre LIKE '%" & Filtro & "%' AND Empresa ='" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "Zonas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Sub AddItem(ByVal Nombre As String)


            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Zonas(Nombre, Empresa) " & _
                        "Values(" & "'" & Nombre & "','" & EmpresaActual & "')"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Sub

        Public Sub Update(ByVal Codigo As String, ByVal Nombre As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE Zonas SET Nombre = '" & Nombre & "' " & "WHERE Codigo = '" & Codigo & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Sub

        Public Sub Delete(ByVal Codigo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM Zonas WHERE Codigo = '" & Codigo & "' AND Empresa ='" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            Try
                cmd.Connection = DBConn
                DBConn.Open()
                cmd.ExecuteNonQuery()
            Catch EXC As Exception
                MsgBox(EXC.Message)
            End Try
            DBConn.Close()

        End Sub

    End Class

End Namespace
