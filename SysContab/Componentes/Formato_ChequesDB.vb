Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class Formato_ChequesDetails
        Public Cuenta As String
        Public Codigo As String
        Public Nombre As String
        Public Direccion As String
        Public Ciudad As String
        Public Telefono As String
        Public Fax As String
        Public Correo As String

    End Class

    Public Class Formato_ChequesDB

        Public Function GetDetails(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFormato_Cheques As New DataSet()
            Dim Details As New Formato_ChequesDetails()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM Formato_Cheques WHERE Codigo = '" & Codigo & "' And Empresa = '" & EmpresaActual & "'", DBConn)

            DBCommand.Fill(dsFormato_Cheques, "Bancos")

            If dsFormato_Cheques.Tables("Bancos").Rows.Count = 1 Then
                Details.Cuenta = dsFormato_Cheques.Tables("Bancos").Rows(0).Item("Cuenta")
                Details.Codigo = dsFormato_Cheques.Tables("Bancos").Rows(0).Item("Codigo")
                Details.Nombre = dsFormato_Cheques.Tables("Bancos").Rows(0).Item("Nombre")
                Details.Direccion = dsFormato_Cheques.Tables("Bancos").Rows(0).Item("Direccion")
                Details.Ciudad = dsFormato_Cheques.Tables("Bancos").Rows(0).Item("Ciudad")
                Details.Telefono = dsFormato_Cheques.Tables("Bancos").Rows(0).Item("Telefono")
                Details.Fax = dsFormato_Cheques.Tables("Bancos").Rows(0).Item("Fax")
                Details.Correo = dsFormato_Cheques.Tables("Bancos").Rows(0).Item("Email")

            End If

            Return Details

        End Function

        Public Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo_Formato AS Formato, Linea_Fecha AS [Linea Fecha], Columna_Fecha AS [Columna Fehca], Comprimido, Linea_Valor AS [Linea Valor], Columna_Valor AS [Columna_Valor], Comprimido_Valor AS [Valor Comprimido], Linea_Valor_Letras AS [Linea del Valor en Letras], Columna_Valor_Letras AS [Columna del Valor en Letras], Comprimido_Valor_Letras AS [Valor en Letras Comprimido], Linea_Nombre AS [Linea del Nombre], Columna_Nombre AS [Columna del Nombre], Comprimido_Nombre AS [Nombre Comprimido] FROM Formato_Cheques WHERE Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "Formato_Cheques")

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

            DBCommand = New SqlDataAdapter("SELECT Codigo, Cuenta, Nombre, Direccion, Ciudad, Telefono FROM Bancos WHERE Nombre Like '%" & Filtro & "%' And Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "BANCOS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListCodigo(ByVal Filtro As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("Select CodGrup as [Código], Nombre, Nivel, Total From GRUPOS WHERE Tipo = '" & Tipo & "' AND CodGrup ='" & Filtro & "' AND Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "GRUPOS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListCatalogo() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo, Cuenta, Nombre, Direccion, Ciudad, Telefono, Email FROM Bancos WHERE Empresa = '" & EmpresaActual & "' ORDER BY Codigo DESC", DBConn)
            DBCommand.Fill(dsFicha, "Bancos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function Delete(ByVal Codigo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM Bancos WHERE Codigo = '" & Codigo & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function AddItem(ByVal Cuenta As String, ByVal Nombre As String, ByVal Direccion As String, ByVal Ciudad As String, ByVal Telefono As String, _
                                ByVal Fax As String, ByVal Correo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ' Se define el tipo de comando

            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Bancos(Cuenta, Nombre, Direccion, Ciudad, Telefono, Fax, Email, Empresa) " & _
                        "Values(" & "'" & Cuenta & "','" & Nombre & "','" & Direccion & "','" & Ciudad & "','" & Telefono & "','" & Fax & "','" & Correo & "','" & EmpresaActual & "')"
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

        Public Function Update(ByVal Cuenta As String, ByVal Codigo As String, ByVal Nombre As String, ByVal Direccion As String, ByVal Ciudad As String, ByVal Telefono As String, _
                               ByVal Fax As String, ByVal Correo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE Bancos SET Nombre = '" & Nombre & "', " & _
                                "Cuenta = '" & Cuenta & "', " & _
                                "Direccion = '" & Direccion & "', " & _
                                "Ciudad = '" & Ciudad & "', " & _
                                "Telefono = '" & Telefono & "', " & _
                                "Fax = '" & Fax & "', " & _
                                "Email = '" & Correo & "' " & _
                                "WHERE Codigo = '" & Codigo & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

    End Class

End Namespace
