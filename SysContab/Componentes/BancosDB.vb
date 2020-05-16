Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports DbConnect

Namespace VB.SysContab

    Public Class BancosDetails
        Public Cuenta As String
        Public Codigo As String
        Public Nombre As String
        Public Direccion As String
        Public Ciudad As String
        Public Telefono As String
        Public Fax As String
        Public Correo As String
        Public Activo As String
        Public Siglas As String

    End Class

    Public Class BancosDB

        Public Function GetListBancosCombo() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListBancosCombo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent2.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "BANCOS")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function GetListReporte2(ByVal Empresa As String) As DataTable
            Dim v As New Connect(VB.SysContab.Rutinas.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Try
                Return v.EjecutarComando("_GetListBancosReporte2")

            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Function


        Public Function ListAll() As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_BancosListAll", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)


            DBCommand.Fill(dsFicha, "Bancos")

            DBConn.Close()

            Return dsFicha


        End Function

        Public Function List() As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_BancosList", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)


            DBCommand.Fill(dsFicha, "Bancos")

            DBConn.Close()

            Return dsFicha


        End Function

        Public Function Cuentas(ByVal Banco As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Numero_Cuenta FROM CATALOGO_BANCOS WHERE BANCO = " & Banco & " AND EMPRESA = " & EmpresaActual, DBConn)
            DBCommand.Fill(dsFicha, "CATALOGO_BANCOS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListBancosReporte", DBConn)

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

        Public Shared Function GetDetails(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsBancos As New DataSet
            Dim Details As New BancosDetails

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM Bancos WHERE Codigo = '" & Codigo & "' And Empresa = '" & EmpresaActual & "'", DBConn)

            DBCommand.Fill(dsBancos, "Bancos")

            If dsBancos.Tables("Bancos").Rows.Count = 1 Then
                Details.Cuenta = dsBancos.Tables("Bancos").Rows(0).Item("Cuenta").ToString
                Details.Codigo = dsBancos.Tables("Bancos").Rows(0).Item("Codigo").ToString
                Details.Nombre = dsBancos.Tables("Bancos").Rows(0).Item("Nombre").ToString
                Details.Direccion = dsBancos.Tables("Bancos").Rows(0).Item("Direccion").ToString
                Details.Ciudad = dsBancos.Tables("Bancos").Rows(0).Item("Ciudad").ToString
                Details.Telefono = dsBancos.Tables("Bancos").Rows(0).Item("Telefono").ToString
                Details.Fax = dsBancos.Tables("Bancos").Rows(0).Item("Fax").ToString
                Details.Correo = dsBancos.Tables("Bancos").Rows(0).Item("Email").ToString
                Details.Activo = dsBancos.Tables("Bancos").Rows(0).Item("Activo").ToString
                Details.Siglas = dsBancos.Tables("Bancos").Rows(0).Item("Siglas").ToString
            End If

            Return Details

        End Function

        Public Function GetListActivos() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_BancosGetListActivos", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)


            DBCommand.Fill(dsFicha, "BANCOS")

            DBConn.Close()

            Return dsFicha

        End Function


        Public Shared Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_BancosGetList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)


            DBCommand.Fill(dsFicha, "BANCOS")

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

            DBCommand = New SqlDataAdapter("SELECT Codigo, Cuenta, Nombre, Direccion, Ciudad, Telefono FROM Bancos WHERE Nombre Like '%" & Filtro & "%' And Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "BANCOS")

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

            DBCommand = New SqlDataAdapter("Select CodGrup as [Código], Nombre, Nivel, Total From GRUPOS WHERE Tipo = '" & Tipo & "' AND CodGrup ='" & Filtro & "' AND Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "GRUPOS")

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

        Public Shared Function Delete(ByVal Codigo As String) As Boolean

            Dim v As New Connect(VB.SysContab.Rutinas.AbrirConexion)
            v.AddParameter("Codigo", SqlDbType.NVarChar, 10, ParameterDirection.Input, Codigo)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Try
                v.EjecutarComando("_BancosDelete")
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
            '' Crea una instancia de conexion y un comando SQL
            'Dim cmd As New SqlCommand
            'Dim DBConn As SqlConnection

            'Dim conexion As New VB.SysContab.Rutinas
            'DBConn = New SqlConnection(Rutinas.AbrirConexion)

            '' Se define el tipo de comando
            'cmd.CommandType = CommandType.Text
            'cmd.CommandText = "DELETE FROM Bancos WHERE Codigo = '" & Codigo & "' AND Empresa = '" & EmpresaActual & "'"

            ''Se asigna conexion al comando y se abre conexion 
            'cmd.Connection = DBConn
            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()

        End Function

        Public Shared Function AddItem(ByVal Cuenta As String, ByVal Nombre As String, ByVal Direccion As String, ByVal Ciudad As String, ByVal Telefono As String, _
                                ByVal Fax As String, ByVal Correo As String, ByVal Activo As Integer, ByVal Siglas As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ' Se define el tipo de comando

            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Bancos(Cuenta, Nombre, Direccion, Ciudad, Telefono, Fax, Email, Activo, Empresa, SIGLAS) " & _
                        "Values(" & "'" & Cuenta & "','" & Nombre & "','" & Direccion & "','" & Ciudad & "','" & Telefono & "','" & Fax & "','" & Correo & "' ," & Activo & " ,'" & EmpresaActual & "','" & Siglas & "')"
            'Try
            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()
            'Catch ex As Exception
            'MsgBox(ex.Message)
            'End Try
        End Function

        Public Shared Function Update(ByVal Cuenta As String, ByVal Codigo As String, ByVal Nombre As String, ByVal Direccion As String, ByVal Ciudad As String, ByVal Telefono As String, _
                               ByVal Fax As String, ByVal Correo As String, ByVal Activo As Integer, ByVal Siglas As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE Bancos SET Nombre = '" & Nombre & "', " & _
                                "Cuenta = '" & Cuenta & "', " & _
                                "Direccion = '" & Direccion & "', " & _
                                "Ciudad = '" & Ciudad & "', " & _
                                "Telefono = '" & Telefono & "', " & _
                                "Fax = '" & Fax & "', " & _
                                "Email = '" & Correo & "', " & _
                                "Siglas = '" & Siglas & "', " & _
                                "Activo = " & Activo & " " & _
                                "WHERE Codigo = '" & Codigo & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function GetListInicio() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT TEMPORAL FROM TEMPORAL", DBConn)
            DBCommand.Fill(dsFicha, "TEMPORAL")

            DBConn.Close()

            Return dsFicha

        End Function

    End Class

End Namespace
