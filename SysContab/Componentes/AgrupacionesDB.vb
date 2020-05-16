Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class AgrupacionesDetails
        Public Codigo As String
        Public Nombre As String
        Public Nivel As String
        Public Total As String

    End Class

    Public Class AgrupacionesDB

        Public Shared Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListAgrupacionesReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = Empresa
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Agrupaciones")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GetDetails(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsAgrupaciones As New DataSet
            Dim Details As New AgrupacionesDetails

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM AGRUPACIONES WHERE Codigo_Agrupacion = '" & Codigo & "' And Empresa = '" & EmpresaActual & "'", DBConn)

            DBCommand.Fill(dsAgrupaciones, "Agrupaciones")

            DBConn.Close()

            If dsAgrupaciones.Tables("Agrupaciones").Rows.Count = 1 Then
                Details.Codigo = dsAgrupaciones.Tables("Agrupaciones").Rows(0).Item("Codigo_Agrupacion")
                Details.Nombre = dsAgrupaciones.Tables("Agrupaciones").Rows(0).Item("Nombre")
                Details.Nivel = dsAgrupaciones.Tables("Agrupaciones").Rows(0).Item("Nivel")
                Details.Total = dsAgrupaciones.Tables("Agrupaciones").Rows(0).Item("Total")

            End If

            Return Details

        End Function

        Public Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT CODIGO_AGRUPACION AS [CODIGO ], NOMBRE FROM AGRUPACIONES WHERE Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "AGRUPACIONES")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT CODIGO_AGRUPACION AS [CODIGO ], NOMBRE FROM AGRUPACIONES WHERE Nombre Like '%" & Filtro & "%' And Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "AGRUPACIONES")

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

            Try
                DBCommand = New SqlDataAdapter("Select CODIGO_AGRUPACION, cast(CODIGO_AGRUPACION as nvarchar(10)) +  '-' + rtrim(ltrim(NOMBRE)) as NOMBRE From AGRUPACIONES WHERE cast(CODIGO_AGRUPACION as nvarchar(10)) +  '-' + rtrim(ltrim(NOMBRE)) Like '" & Filtro & "%' AND Empresa = '" & EmpresaActual & "'", DBConn)
                DBCommand.Fill(dsFicha, "AGRUPACIONES")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Return dsFicha

        End Function

        Public Function GetListCodigo(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("Select CODIGO_AGRUPACION, NOMBRE, NIVEL, TOTAL From AGRUPACIONES WHERE CODIGO_AGRUPACION ='" & Filtro & "' AND Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "AGRUPACIONES")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListCatalogo() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo, Cuenta, Nombre, Direccion, Ciudad, Telefono, Email FROM Bancos WHERE Empresa = '" & EmpresaActual & "' ORDER BY Codigo DESC", DBConn)
            DBCommand.Fill(dsFicha, "Bancos")

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
            cmd.CommandText = "DELETE FROM AGRUPACIONES WHERE Codigo_Agrupacion = '" & Codigo & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function AddItem(ByVal Codigo As String, ByVal Nombre As String, ByVal Nivel As String, ByVal Total As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ' Se define el tipo de comando

            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO AGRUPACIONES(CODIGO_AGRUPACION, NOMBRE, NIVEL, TOTAL, EMPRESA) " & _
                        "Values(" & "'" & Codigo & "','" & Nombre & "','" & Nivel & "','" & Total & "','" & EmpresaActual & "')"
            Try
                'Se asigna conexion al comando y se abre conexion 
                cmd.Connection = DBConn
                DBConn.Open()
                cmd.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function

        Public Function Update(ByVal Codigo As String, ByVal Nombre As String, ByVal Nivel As String, ByVal Total As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE AGRUPACIONES SET Nombre = '" & Nombre & "', " & _
                              "NIVEL = '" & Nivel & "', " & _
                              "TOTAL = '" & Total & "' " & _
                              "WHERE Codigo_Agrupacion = '" & Codigo & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

    End Class

End Namespace
